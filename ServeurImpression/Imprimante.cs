using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServeurImpression
{
    public class Imprimante
    {
        public string Nom { get; set; }
        public float PagesParMinute { get; set; }
        public Etat Etat { get; private set; }
        public List<Document> DocumentsEnAttente { get; private set; }
        public List<Document> DocumentsEnErreur { get; private set; }
        private int NbPagesRestantes;
        public EventWaitHandle EvenementImprimer { get; private set; }
        public Document DocumentEnCours { get; set; }

        public Imprimante(string nom, float pagesParMinute)
        {
            Nom = nom;
            PagesParMinute = pagesParMinute;
            DocumentsEnAttente = new List<Document>();
            DocumentsEnErreur = new List<Document>();
            EvenementImprimer = new AutoResetEvent(false);
        }

        public int Travailler()
        {
            while (true)
            {
                EvenementImprimer.WaitOne();
                while (PeutImprimer())
                {
                    Imprimer();
                }
            }
            return -1;
        }

        public void Imprimer()
        {
            Console.WriteLine("Imprimante {0} commence à imprimer", Nom);
            DocumentEnCours = DocumentsEnAttente.First();
            DocumentsEnAttente.RemoveAt(0);

            NbPagesRestantes = DocumentEnCours.GetNbPages();
            float tempsDImpression = getTempsPrévuPourDoc(DocumentEnCours);
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
            DocumentEnCours = null;
        }

        public float TempsPrévu(Document doc)
        {
            return TempsTotalPourDocumentsEnAttente() + getTempsRestantDocEnCours();
        }

        public float TempsTotalPourDocumentsEnAttente()
        {
            float temps = 0;
            List<Document> documentsEnAttente = new List<Document>(DocumentsEnAttente);
            foreach(Document docEnAttente in documentsEnAttente) 
            {
                temps += getTempsPrévuPourDoc(docEnAttente);
            }
            return temps;
        }

        public void AjouterDocument(Document doc)
        {
            DocumentsEnAttente.Add(doc);
            EvenementImprimer.Set();
        }

        public Document GetDocumentParId(int id)
        {
            foreach (Document doc in DocumentsEnAttente)
            {
                if (doc.Id == id)
                    return doc;
            }
            return null;
        }

        public void SupprimerDocument(int id)
        {
            for (int i = 0; i < DocumentsEnAttente.Count; i++)
            {
                if (DocumentsEnAttente.ElementAt(i).Id == id)
                {
                    DocumentsEnAttente.RemoveAt(i);
                    break;
                }
            }
        }

        public bool PeutImprimer()
        {
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count > 0;
        }

        public float getTempsPrévuPourDoc(Document doc)
        {
            return (doc.GetNbPages() * PagesParMinute) * 60;
        }

        public bool EstEnCoursDImpression(int id)
        {
            return DocumentEnCours != null && DocumentEnCours.Id == id;
        }

        public void AnnulerImpression()
        {
            DocumentEnCours = null;
        }

        private float getTempsRestantDocEnCours()
        {
            return (NbPagesRestantes * PagesParMinute) * 60;
        }

        private bool estLibre()
        {
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count == 0;
        }
    }
}
