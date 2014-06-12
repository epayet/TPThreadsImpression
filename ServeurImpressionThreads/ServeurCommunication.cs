using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceImpression.Data;

namespace ServeurImpressionThreads
{
    public interface ServeurCommunication
    {
        void AjouterDocument(Document doc);
        void SupprimerDocument(Document monDoc);
        List<Imprimante> GetImprimantes();
    }
}
