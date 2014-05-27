using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpression
{
    public class Document
    {
        public byte[] document;
        public Document( byte[] source)
        {
            document = source;
        }

        public int nbrPages()
        {
            return document.Length / 100000;
        }
    
    }
}
