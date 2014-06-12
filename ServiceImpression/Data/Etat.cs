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
        EN_LIGNE,
        HORS_LIGNE,
        ERREUR
    }
}
