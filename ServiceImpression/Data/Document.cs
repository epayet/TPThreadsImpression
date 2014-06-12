using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImpression.Data
{
    [DataContract]
    public class Document
    {
        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Nom {get; set;}

        [DataMember]
        public byte[] Contenu { get; set;}

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
