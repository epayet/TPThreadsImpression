using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpression
{
    public class Document
    {
        public int Id { get; set; }
        public string Nom {get; set;}
        public byte[] Contenu { get; set;}

        public int GetNbPages()
        {
            return Contenu.Length / 100000;
        }
    
    }
}
