using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServeurImpression.Message
{
    [DataContract]
    public class TcpListenerMessage
    {
        [DataMember]
        public string Addresse { get; set; }

        [DataMember]
        public int Port { get; set; }
    }
}
