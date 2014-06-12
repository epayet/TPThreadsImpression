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
    public class WebServiceImpression : IWebServiceImpression
    {
        private ImpressionService _impressionService;
        private ImpressionService impressionService
        {
            get
            {
                if (_impressionService == null)
                    _impressionService = creerImpressionService();
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
            impressionService.SupprimerDocument(document);
        }

        public List<Imprimante> GetImprimantes()
        {
            return impressionService.Imprimantes;
        }

        public void AjouterImprimante(Imprimante imprimante)
        {
            impressionService.AjouterImprimante(imprimante);
        }

        public void SupprimerImprimante(Imprimante imprimante)
        {
            impressionService.SupprimerImprimante(imprimante);
        }

        private ImpressionService creerImpressionService()
        {
            ImpressionService service = new ImpressionService();
            service.Lancer();
            return service;
        }
    }
}
