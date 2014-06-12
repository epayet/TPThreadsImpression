using ServiceImpression;
using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServeurImpression
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WebServiceImpression : IWebServiceImpression
    {
        private ImpressionService _impressionService;
        private ImpressionService impressionService
        {
            get
            {
                if (_impressionService == null)
                    _impressionService = new ImpressionService();
                return _impressionService;
            }
            set
            {
                _impressionService = value;
            }
        }

        public Imprimante AjouterDocument(Document document)
        {
            return impressionService.AjouterDocument(document);
        }

        public void SupprimerDocument(Document document)
        {

        }

        public List<Imprimante> GetImprimantes()
        {
            return impressionService.Imprimantes;
        }

        public void AjouterImprimante(Imprimante imprimante)
        {

        }

        public void SupprimerImprimante(Imprimante imprimante)
        {

        }
    }
}
