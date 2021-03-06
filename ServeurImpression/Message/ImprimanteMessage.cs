﻿using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServeurImpression.Message
{
    [DataContract]
    public class ImprimanteMessage
    {
        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public float PagesParMinute { get; set; }

        [DataMember]
        public Etat Etat { get; set; }

        [DataMember]
        public List<DocumentMessage> DocumentsEnAttente {get;set;}

        [DataMember]
        public DocumentMessage DocumentEnCours { get; set; }

        [DataMember]
        public List<DocumentMessage> DocumentsEnErreur { get; set; }


    }
}