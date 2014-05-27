using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServeurImpression
{
    class Serveur
    {
        public const string PATH = "c:\tpImpression";

        string ajouter(byte[] source)
        {
            Document doc = new Document(source);
            return "";
        }
    }
}
