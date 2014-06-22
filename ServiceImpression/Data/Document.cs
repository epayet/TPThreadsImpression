using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImpression.Data
{
    public class Document
    {
        public string Id { get; private set; }

        public string Nom {get; set;}

        public byte[] Contenu { get; set;}

        private Document()
        {

        }

        public Document(string nom, byte[] contenu)
        {
            Nom = nom;
            Contenu = contenu;
        }

        public int GetNbPages()
        {
            float nbPages = Contenu.Length / 100000f;
            return (int)Math.Ceiling(nbPages);
        }

        public Document Clone()
        {
            return new Document
                {
                    Id = Id,
                    Nom = Nom,
                    Contenu = Contenu
                };
        }

        public void GenererId()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
