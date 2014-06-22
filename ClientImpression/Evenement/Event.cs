using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads.Evenement
{
    public class Event
    {
        public string NomImprimante { get; set; }

        public EventType Type { get; set; }

        public Event(string data)
        {
            string [] split = data.Split(':');
            this.NomImprimante = split[0];
            this.Type = (EventType)Enum.Parse(typeof(EventType), split[1], true);
        }
    }
}
