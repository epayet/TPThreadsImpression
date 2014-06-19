using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceImpression.Data
{
    public class Imprimante
    {
        public string Nom { get; set; }

        public float PagesParMinute { get; set; }

        public Etat Etat { get; private set; }

        public ConcurrentDictionary<int, Document> DocumentsEnAttente = new ConcurrentDictionary<int, Document>();

        public ConcurrentDictionary<string, Document> DocumentsEnErreur = new ConcurrentDictionary<string, Document>();

        #region pages restantes
        private int _nbPagesRestantes;
        private readonly Object verrouPagesRestantes = new object();
        public int NbPagesRestantes { 
            get 
            {
                return _nbPagesRestantes;
            } 
            set 
            {
                lock (verrouPagesRestantes)
                {
                    _nbPagesRestantes = value;
                }
            } 
        }
        #endregion

        #region document en cours
        private readonly Object verrouDocumentEnCours = new object();
        private Document _documentEnCours;
        public Document DocumentEnCours {
            get
            {
                Document copy = null;
                lock (verrouDocumentEnCours)
                {
                    if(_documentEnCours != null)
                        copy = _documentEnCours.Clone();
                }
                return copy;
            } 
            set
            {
                lock (verrouDocumentEnCours)
                {
                    _documentEnCours = value;
                }
            }
        }
        #endregion

        private EventWaitHandle PortiqueImpression;

        private bool arreterImprimante = false;

        public Imprimante(string nom, float pagesParMinute)
        {
            Nom = nom;
            PagesParMinute = pagesParMinute;
            PortiqueImpression = new AutoResetEvent(false);
        }

        public void Travailler()
        {
            while (!arreterImprimante)
            {
                PortiqueImpression.WaitOne();
                while (PeutImprimer())
                {
                    Imprimer();
                }
            }
        }
        
        public void Arreter()
        {
            arreterImprimante = false;
            DocumentEnCours = null;
            NbPagesRestantes = 0;
            PortiqueImpression.Set();
        }

        public void Imprimer()
        {
            Console.WriteLine("Imprimante {0} commence à imprimer", Nom);

            RecupererDocumentAImprimer();

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

            if(DocumentEnCours != null)
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
            foreach (KeyValuePair<int, Document> docCleValeur in DocumentsEnAttente)
            {
                Document docEnAttente = docCleValeur.Value;
                temps += GetTempsPrévuPourDoc(docEnAttente);
            }
            return temps;
        }

        public void AjouterDocument(Document doc)
        {
            int nbDocs = DocumentsEnAttente.Count;
            DocumentsEnAttente.TryAdd(nbDocs, doc);
            //Déclenche l'évènement d'impression
            PortiqueImpression.Set();
        }

        public Document GetDocument(string id)
        {
            Document document;
            int indexDocumentEnAttente = getIndexDocumentEnAttente(id);
            DocumentsEnAttente.TryGetValue(indexDocumentEnAttente, out document);
            return document;
        }

        public void SupprimerDocumentEnAttente(string id)
        {
            Document documentSupprime;
            int indexDocumentEnAttente = getIndexDocumentEnAttente(id);
            DocumentsEnAttente.TryRemove(indexDocumentEnAttente, out documentSupprime);
        }

        public bool PeutImprimer()
        {
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count > 0;
        }

        public float GetTempsPrévuPourDoc(Document doc)
        {
            return (doc.GetNbPages() * PagesParMinute) * 60;
        }

        public bool EstEnCoursDImpression(string id)
        {
            return DocumentEnCours != null && DocumentEnCours.Id == id;
        }

        public void AnnulerImpression()
        {
            DocumentEnCours = null;
        }

        private void RecupererDocumentAImprimer()
        {
            Document premierDocument;
            int nbPremierDocumentEnAttente = getNbPremierDocumentEnAttente();
            DocumentsEnAttente.TryGetValue(nbPremierDocumentEnAttente, out premierDocument);
            DocumentEnCours = premierDocument;
            NbPagesRestantes = DocumentEnCours.GetNbPages();
            Document documentSupprime;
            DocumentsEnAttente.TryRemove(nbPremierDocumentEnAttente, out documentSupprime);
            nbPremierDocumentEnAttente++;
        }

        private int getNbPremierDocumentEnAttente()
        {
            int nbMin = DocumentsEnAttente.First().Key;
            foreach (KeyValuePair<int, Document> docCleValeur in DocumentsEnAttente)
            {
                if (docCleValeur.Key < nbMin)
                    nbMin = docCleValeur.Key;
            }
            return nbMin;
        }

        private float getTempsRestantDocEnCours()
        {
            return (NbPagesRestantes * PagesParMinute) * 60;
        }

        private bool estLibre()
        {
            return NbPagesRestantes == 0 && DocumentsEnAttente.Count == 0;
        }

        private int getIndexDocumentEnAttente(string id)
        {
            foreach (KeyValuePair<int, Document> documentsCleValeur in DocumentsEnAttente)
            {
                if (documentsCleValeur.Value.Id.Equals(id))
                    return documentsCleValeur.Key;
            }
            throw new Exception("Document " + id + " non en file d'attente");
        }

        public List<Document> GetListeDocumentsEnAttente()
        {
            List<Document> liste = new List<Document>();
            foreach (KeyValuePair<int, Document> documentsCleValeur in DocumentsEnAttente)
            {
                liste.Add(documentsCleValeur.Value);
            }
            return liste;
        }
    }
}
