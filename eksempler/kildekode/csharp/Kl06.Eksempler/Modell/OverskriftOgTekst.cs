using System.ComponentModel;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract (Name = "overskrift-og-tekst")]
    public class OverskriftOgTekst
    {

        [DataMember(Order = 4, Name = "overskrift")]
        [Description("Overskrift")]
        public List<Språkversjonert> Overskrift { get; set; }

        [DataMember(Order = 5, Name = "tekst")]
        [Description("Tekst")]
        public List<Språkversjonert> tekst { get; set; }

    }
}
