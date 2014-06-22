using ServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceImpression.Evenement.Listeners
{
    public class WCFConsoleLogEventListener : EventListener
    {
        public WCFConsoleLogEventListener()
            : base("WCFConsoleLogEvent")
        {

        }

        public override void DebutImpression(ServiceImpression.Data.Imprimante imprimante)
        {
            System.Diagnostics.Debug.WriteLine("Imprimante {0} commence à imprimer", imprimante.Nom);
        }

        public override void ImpressionPage(ServiceImpression.Data.Imprimante imprimante, int nbPagesImprimees)
        {
            System.Diagnostics.Debug.WriteLine("{0}: Page {1} imprimée", imprimante.Nom, nbPagesImprimees);
        }

        public override void FinImpression(ServiceImpression.Data.Imprimante imprimante, ServiceImpression.Data.Document DocumentEnCours)
        {
            System.Diagnostics.Debug.WriteLine("Imprimante {0} a imprimé le document {1}", imprimante.Nom, DocumentEnCours.Nom);
        }
    }
}