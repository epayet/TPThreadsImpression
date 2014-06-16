using ServeurImpression.Message;
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
    [ServiceContract]
    public interface IWebServiceImpression
    {
        [OperationContract]
        Imprimante AjouterDocument(DocumentMessage document);

        [OperationContract]
        void SupprimerDocument(Document document);

        [OperationContract]
        List<Imprimante> GetImprimantes();

        [OperationContract]
        void AjouterImprimante(Imprimante imprimante);

        [OperationContract]
        void SupprimerImprimante(Imprimante imprimante);

        [OperationContract]
        int GetDocumentNbPages(Document document);

        [OperationContract]
        float GetTempsPrevuPourImpression(Imprimante imprimante, Document document);
    }
}
