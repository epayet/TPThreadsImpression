using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceImpression.Data
{
    [DataContract]
    public class Imprimante
    {
        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public float PagesParMinute { get; set; }

        [DataMember]
        public Etat Etat { get; private set; }

        [DataMember]
        public List<Document> DocumentsEnAttente {
            get 
            {
                List<Document> copy;
                lock (DocumentsEnAttente)
                {
                    copy = new List<Document>(DocumentsEnAttente);
                }
                return copy;
            } 
            set 
            {
                lock (DocumentsEnAttente)
                {
                    DocumentsEnAttente = value;
                }
            } 
        }
        public List<Document> DocumentsEnErreur {
             get 
            {
                List<Document> copy;
                lock (DocumentsEnErreur)
                {
                    copy = new List<Document>(DocumentsEnErreur);
                }
                return copy;
            } 
            set 
            {
                lock (DocumentsEnErreur)
                {
                    DocumentsEnErreur = value;
                }
            } 
        }
        private int nbPagesRestantes;
        private readonly Object verrouPagesRestantes = new object();
        public int NbPagesRestantes { 
            get 
            {
                return nbPagesRestantes;
            } 
            set 
            {
                lock (verrouPagesRestantes)
                {
                    nbPagesRestantes = value;
                }
            } 
        }
        public EventWaitHandle EvenementImprimer { get; private set; }
        public Document DocumentEnCours {
            get
            {
                Document copy;
                lock (DocumentEnCours)
                {
                    copy = DocumentEnCours.Clone();
                }
                return copy;
            } 
            set
            {
                lock (DocumentEnCours)
                {
                    DocumentEnCours = value;
                }
            }
        }
        public Imprimante(string nom, float pagesParMinute)
        {
            Nom = nom;
            PagesParMinute = pagesParMinute;
            DocumentsEnAttente = new List<Document>();
            DocumentsEnErreur = new List<Document>();
            EvenementImprimer = new AutoResetEvent(false);
        }

        public void Travailler()
        {
            while (arreterImprimante)
            {
                EvenementImprimer.WaitOne();
                while (PeutImprimer())
                {
                    Imprimer();
                }
            }
        }
        private bool arreterImprimante = true; 
        
        public void ArreterImprimante()
        {
            arreterImprimante = false;
            EvenementImprimer.Set();

        }

        public void Imprimer()
        {
            Console.WriteLine("Imprimante {0} commence à imprimer", Nom);
            //Accès concurentiel possible
            DocumentEnCours = DocumentsEnAttente.First();
            //Accès concurentiel possible
            DocumentsEnAttente.RemoveAt(0);

            //Accès concurentiel possible
            NbPagesRestantes = DocumentEnCours.GetNbPages();
            float tempsDImpression = GetTempsPrévuPourDoc(DocumentEnCours);
            float tempsDImpressionPourUnePage = tempsDImpression / NbPagesRestantes;
            int nbPagesImprimees = 1;
            while (NbPagesRestantes != 0 && DocumentEnCours != null)
            {
                Thread.Sleep((int)(tempsDImpressionPourUnePage * 1000));
                Console.WriteLine("{0}: Page {1} imprimée", Nom, nbPagesImprimees);
                NbPagesRestantes--;
                nbPagesImprimees++;
            }

            Console.WriteLine("Imprimante {0} a imprimé le document {1}", Nom, DocumentEnCours.Nom);
            //Accès concurentiel possible
            DocumentEnCours = null;
        }

        public float TempsPrévu(Document doc)
        {
            return TempsTotalPourDocumentsEnAttente() + getTempsRestantDocEnCours();
        }

        public float TempsTotalPourDocumentsEnAttente()
        {
            float temps = 0;

            List<Document> documentsEnAttente = new List<Document>();

            lock (DocumentsEnAttente)
            {
                //TODO clone plutot que =
                documentsEnAttente = DocumentsEnAttente;
            }

            foreach(Document docEnAttente in documentsEnAttente) 
            {
                temps += GetTempsPrévuPourDoc(docEnAttente);
            }
            return temps;
        }

        public void AjouterDocument(Document doc)
        {
            //Accès concurentiel possible
            DocumentsEnAttente.Add(doc);
            //Déclenche l'évènement d'impression
            EvenementImprimer.Set();
        }

        public Document GetDocumentParId(int id)
        {
            //Accès concurentiel possible
            foreach (Document doc in DocumentsEnAttente)
            {
                if (doc.Id == id)
                    return doc;
            }
            return null;
        }

        public void SupprimerDocumentEnAttente(int id)
        {
            //Accès concurentiel possible
            for (int i = 0; i < DocumentsEnAttente.Count; i++)
            {
                //Accès concurentiel possible
                if (DocumentsEnAttente.ElementAt(i).Id == id)
                {
                    lock (DocumentsEnAttente)
                    {
                        DocumentsEnAttente.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public bool PeutImprimer()
        {
            //Accès concurentiel possible
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count > 0;
        }

        public float GetTempsPrévuPourDoc(Document doc)
        {
            return (doc.GetNbPages() * PagesParMinute) * 60;
        }

        public bool EstEnCoursDImpression(int id)
        {
            //Accès concurentiel possible
            return DocumentEnCours != null && DocumentEnCours.Id == id;
        }

        public void AnnulerImpression()
        {
            //Accès concurentiel possible
            DocumentEnCours = null;
        }

        private float getTempsRestantDocEnCours()
        {
            return (NbPagesRestantes * PagesParMinute) * 60;
        }

        private bool estLibre()
        {
            //Accès concurentiel possible
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count == 0;
        }
    }
}
