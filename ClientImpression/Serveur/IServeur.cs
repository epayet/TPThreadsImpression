using ServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceImpression.Data;

namespace ServeurImpressionThreads.Serveur
{
    public interface IServeur
    {
        void AjouterDocument(Document doc);
        void SupprimerDocument(Document monDoc);
        List<Imprimante> GetImprimantes();
    }
}
