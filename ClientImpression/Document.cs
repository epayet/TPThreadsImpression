using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads
{
    public class Document
    {
        public int Id { get; private set; }
        public string Nom { get; set; }
        public byte[] Contenu { get; set; }
        private static int TotalNbDocs = 0;

        public Document(string nom, byte[] contenu)
        {
            TotalNbDocs++;
            Id = TotalNbDocs;
            Nom = nom;
            Contenu = contenu;
        }

        public int GetNbPages()
        {
            return Contenu.Length / 100000;
        }

    }
}
