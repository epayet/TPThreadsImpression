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
        private List<Document> DocumentsEnAttente;
        private List<Document> DocumentsEnErreur;
        private int NbPagesRestantes;

        public void Imprimer()
        {
            Document documentEnCours = DocumentsEnAttente.First();
            DocumentsEnAttente.RemoveAt(0);

            NbPagesRestantes = documentEnCours.GetNbPages();
            float tempsDImpression = getTempsPrévuPourDoc(documentEnCours);
            float tempsDImpressionPourUnePage = tempsDImpression / NbPagesRestantes;
            while (NbPagesRestantes != 0)
            {
                Thread.Sleep((int)(tempsDImpressionPourUnePage / 1000));
                NbPagesRestantes--;
            }

            documentEnCours = null;
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

        public void AjouterDocumentAImprimer(Document doc)
        {
            DocumentsEnAttente.Add(doc);
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

        private float getTempsPrévuPourDoc(Document doc)
        {
            return (doc.GetNbPages() * PagesParMinute) / 60;
        }

        private float getTempsRestantDocEnCours()
        {
            return (NbPagesRestantes * PagesParMinute) / 60;
        }
    }
}
