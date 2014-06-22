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
        ImprimanteMessage AjouterDocument(DocumentMessage document);

        [OperationContract]
        void SupprimerDocument(DocumentMessage document);

        [OperationContract]
        List<ImprimanteMessage> GetImprimantes();

        [OperationContract]
        ImprimanteMessage GetImprimante(string nom);

        [OperationContract]
        void AjouterImprimante(ImprimanteMessage imprimante);

        [OperationContract]
        void SupprimerImprimante(ImprimanteMessage imprimante);

        [OperationContract]
        int GetDocumentNbPages(DocumentMessage document);

        [OperationContract]
        float GetTempsPrevuPourImpression(ImprimanteMessage imprimante, DocumentMessage document);

        [OperationContract]
        void AjouterTcpListener(TcpListenerMessage listener);
    }
}
