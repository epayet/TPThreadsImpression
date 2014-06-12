using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceImpression.Data
{
    [DataContract]
    public enum Etat
    {
        [EnumMember]
        EN_LIGNE,
        [EnumMember]
        HORS_LIGNE,
        [EnumMember]
        ERREUR
    }
}
