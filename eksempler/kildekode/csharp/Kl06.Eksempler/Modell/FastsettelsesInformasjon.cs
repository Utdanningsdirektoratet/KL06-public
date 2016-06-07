using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "fastsettelsesinformasjon")]
    [Description("Fastsettelsesinformasjon")]
    public class FastsettelsesInformasjon
    {
        [DataMember(Order = 0, Name = "fastsatt-dato")]
        [Description("Dato for fastsettelsen")]
        public DateTime? FastsattDato { get; set; }

        [DataMember(Order = 1, Name = "fastsettelsestekst")]
        [Description("Ordlyd i fastsettelsen")]
        public List<Språkversjonert> FastsettelsesTekst { get; set; }

        [DataMember(Order = 2, Name = "fastsatt-spraak")]
        [Description("Språket læreplanen er fastsatt på")]
        public Kodeverkverdi FastsattSpråk { get; set; }

        [DataMember(Order = 3, Name = "fastsatt-dato-overskrift")]
        [Description("Overskrift for fastsettelsesdato")]
        public List<Språkversjonert> FastsattDatoOverskrift { get; set; }
    }
}