using System.ComponentModel;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract (Name = "overskrift-og-dato")]
    public class OverskriftOgDato
    {
        [DataMember(Order = 2, Name = "overskrift")]
        [Description("Overskrift for dato")]
        public List<Språkversjonert> Overskrift { get; set; }

        [DataMember(Order = 3, Name = "dato")]
        [Description("Dato")]
        public DateTime? Dato { get; set; }
    }
}
