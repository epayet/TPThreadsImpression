using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceImpression.Data
{
    public class EventNotifier
    {
        private Dictionary<string, EventListener> listeners = new Dictionary<string, EventListener>();

        public void NotifierDebutImpression(Imprimante imprimante)
        {
            foreach(EventListener listener in listeners.Values)
                listener.DebutImpression(imprimante);
        }

        public void NotifierImpressionPage(Imprimante imprimante, int nbPagesImprimees)
        {
            foreach (EventListener listener in listeners.Values)
                listener.ImpressionPage(imprimante, nbPagesImprimees);
        }

        public void NotifierFinImpression(Imprimante imprimante, Document documentEnCours)
        {
            foreach (EventListener listener in listeners.Values)
                listener.FinImpression(imprimante, documentEnCours);
        }

        public void AjouterListener(EventListener listener)
        {
            listeners[listener.Nom] = listener;
        }
    }
}
