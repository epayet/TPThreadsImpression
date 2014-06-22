using ServeurImpressionThreads.Evenement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServeurImpressionThreads
{
    class EventNotifier
    {
        private Dictionary<string, FormImprimante> formsImprimantes;

        public EventNotifier(Dictionary<string, FormImprimante> formsImprimantes)
        {
            this.formsImprimantes = formsImprimantes;
        }

        public void Notify(string data)
        {
            Event evenement = new Event(data);
            //MessageBox.Show(data);
            System.Diagnostics.Debug.WriteLine(data);
            FormImprimante formImprimante;
            this.formsImprimantes.TryGetValue(evenement.NomImprimante, out formImprimante);
            switch (evenement.Type)
            {
                case EventType.DebutImpression:
                    formImprimante.DebutImpression();
                    break;
                case EventType.ImpressionPage:
                    formImprimante.ImpressionPage();
                    break;
                case EventType.FinImpression:
                    formImprimante.FinImpression();
                    break;
            }
        }
    }
}
