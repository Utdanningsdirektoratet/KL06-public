using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "kompetansemaalsett")]
    public class KompetanseMålsettReferanseKm : BaseElement
    {
        [DataMember(Order = 0, Name = "rekkefoelge")]
        public int Rekkefølge { get; set; }

        [DataMember(Order = 1, Name = "etter-fag")]
        public List<Referanse> OpplæringsfagReferanser { get; set; }

        [DataMember(Order = 2, Name = "etter-aarstrinn")]
        public List<Kodeverkverdi> ÅrstrinnReferanser { get; set; } 

    }
}