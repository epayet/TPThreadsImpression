using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads.Serveur.Strategie
{
    public class WebServiceServeur : IServeur
    {
        void IServeur.AjouterDocument(ServiceImpression.Data.Document doc)
        {
            throw new NotImplementedException();
        }

        void IServeur.SupprimerDocument(ServiceImpression.Data.Document monDoc)
        {
            throw new NotImplementedException();
        }

        List<ServiceImpression.Data.Imprimante> IServeur.GetImprimantes()
        {
            throw new NotImplementedException();
        }
    }
}
