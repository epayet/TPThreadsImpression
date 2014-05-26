using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpression
{
    public class Imprimante
    {
        public String Nom { get; set; }
        public int PagesParMinute { get; set; }
        public Etat Etat { get; set; }
        public List<Document> DocumentsEnAttente { get; set; }
        public Document DocumentEnCours { get; set; }
        public List<Document> DocumentsEnErreur { get; set; }

        public void Imprimer()
        {

        }

        public int TempsPrévu(Document doc)
        {
            return -1;
        }
    }
}
