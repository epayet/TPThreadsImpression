using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceImpression.Evenement.Listeners
{
    public class ConsoleLogEventListener : EventListener
    {
        public ConsoleLogEventListener()
            : base("ConsoleLogEvent")
        {

        }

        public override void DebutImpression(Imprimante imprimante)
        {
            Console.WriteLine("Imprimante {0} commence à imprimer", imprimante.Nom);
        }

        public override void ImpressionPage(Imprimante imprimante, int nbPagesImprimees)
        {
            Console.WriteLine("{0}: Page {1} imprimée", imprimante.Nom, nbPagesImprimees);
        }

        public override void FinImpression(Imprimante imprimante, Document DocumentEnCours)
        {
            Console.WriteLine("Imprimante {0} a imprimé le document {1}", imprimante.Nom, DocumentEnCours.Nom);
        }
    }
}
