using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract (Name = "kompetansemaal-kapittel")]
    [Description("Kompetansemål-kapittelet")]

    public class KompetansemålKapittel
    {
        // Kompetansemål //
        [DataMember(Order = 32, Name = "overskrift")]
        [Description("Overskrift for kompetansemålkapittelet")]
        public List<Språkversjonert> KompetansemålOverskrift { get; set; }

        [DataMember(Order = 33, Name = "innledning")]
        [Description("Innledning til kompetansemålkapittelet. Benyttes for å forklare nivåene i Samisk som andrespråk-planen")]
        public List<Språkversjonert> KompetansemålInnledning { get; set; }

        // Kompetansemålsett //
        [DataMember(Order = 35, Name = "kompetansemaalsett")]
        [Description("Liste over kompetansemålsettene i læreplanen")]
        public List<Kompetansemålsett> Kompetansemålsett { get; set; }

    }
}
