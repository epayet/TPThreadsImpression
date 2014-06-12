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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWebServiceImpression
    {
        [OperationContract]
        Imprimante AjouterDocument(Document document);

        [OperationContract]
        void SupprimerDocument(Document document);

        [OperationContract]
        List<Imprimante> GetImprimantes();

        [OperationContract]
        void AjouterImprimante(Imprimante imprimante);

        [OperationContract]
        void SupprimerImprimante(Imprimante imprimante);
    }
}
