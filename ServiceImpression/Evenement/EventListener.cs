using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImpression
{
    public abstract class EventListener
    {
        public string Nom { get; set; }

        public EventListener(string nom)
        {
            this.Nom = nom;
        }

        public abstract void DebutImpression(Imprimante imprimante);

        public abstract void ImpressionPage(Imprimante imprimante, int nbPagesImprimees);

        public abstract void FinImpression(Imprimante imprimante, Document DocumentEnCours);
    }
}
