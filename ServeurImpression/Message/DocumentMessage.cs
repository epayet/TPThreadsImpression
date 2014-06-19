using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServeurImpression.Message
{
    [DataContract]
    public class DocumentMessage
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public byte[] Contenu { get; set; }
    }
}