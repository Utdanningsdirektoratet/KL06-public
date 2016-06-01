using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [Obsolete("Har opprettet ny klasse som kan gjenbrukes")]
    [DataContract (Name = "kompetansemaal-opplaeringsfag")]
    public class KompetansemålOpplæringsfag : Referanse
    {
        [DataMember(Name = "rekkefoelge")]
        [Description("Kompetansemålets rekkefølge")]
        public int Rekkefølge { get; set; }
    }
}
