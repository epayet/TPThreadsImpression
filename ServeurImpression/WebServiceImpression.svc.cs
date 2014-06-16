using ServeurImpression.Message;
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
                    _impressionService = new ImpressionService();
                return _impressionService;
            }
            set
            {
                _impressionService = value;
            }
        }

        public Imprimante AjouterDocument(DocumentMessage documentMessage)
        {
            //TODO
            Document document = null;
            Imprimante imprimante = impressionService.AjouterDocument(document);
            return imprimante;
        }

        public void SupprimerDocument(Document document)
        {
            impressionService.SupprimerDocument(document);
        }

        public List<Imprimante> GetImprimantes()
        {
            return impressionService.GetImprimantes();
        }

        public void AjouterImprimante(Imprimante imprimante)
        {
            impressionService.AjouterImprimante(imprimante);
        }

        public void SupprimerImprimante(Imprimante imprimante)
        {
            impressionService.SupprimerImprimante(imprimante.Nom);
        }


        public int GetDocumentNbPages(Document document)
        {
            return document.GetNbPages();
        }

        public float GetTempsPrevuPourImpression(Imprimante imprimante, Document document)
        {
            return imprimante.GetTempsPrévuPourDoc(document);
        }
    }
}
