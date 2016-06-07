using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    

    [DataContract (Name = "fag")]
    public class Fag : HovedElement
    {
        [DataMember(Order = 0, Name = "kortform")]
        [Description("Kortform av fagets tittel til bruk ved dokumentasjon")]
        public List<Språkversjonert> Kortform { get; set; }

        [DataMember(Order = 1, Name = "erstatter")]
        [Description("hvilke fag dette faget erstatter")]
        public List<Referanse> Erstatter { get; set; }

        [DataMember(Order = 2, Name = "erstattes-av")]
        [Description("hvilke fag dette faget blir erstattet av")]
        public List<Referanse> ErstattesAv { get; set; }
    }
}
