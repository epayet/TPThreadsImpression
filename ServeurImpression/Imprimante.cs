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
        public Etat Etat { get; set; }
        public Queue<Document> DocumentsEnAttente { get; set; }
        public List<Document> DocumentsEnErreur { get; set; }
        public int NbPagesRestantes { get; set; }

        public void Imprimer()
        {
            Document documentEnCours = DocumentsEnAttente.Dequeue();

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
            DocumentsEnAttente.Enqueue(doc);
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
