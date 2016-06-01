using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [Obsolete("Har opprettet ny klasse som kan gjenbrukes")]
    [DataContract (Name = "kompetansemaalsett-referanse")]
    public class KompetansemålsettReferanse : BaseElement
    {
        [DataMember(Name = "rekkefoelge")]
        [Description("Kompetansemålsettets rekkefølge")]
        public int Rekkefølge { get; set; }
        
        [DataMember(Name = "trinn")]
        [Description("Hvilke trinn kompetansemålsettet gjelder for")]
        public List<Kodeverkverdi> Trinn { get; set; }
    }
}