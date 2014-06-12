using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    interface ServeurCommunication
    {
        void AjouterDocument(Document doc);
        void SupprimerDocument(Document monDoc);
    }
}
