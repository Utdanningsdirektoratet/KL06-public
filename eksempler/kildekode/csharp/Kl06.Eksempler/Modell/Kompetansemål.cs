using System.ComponentModel;
using System.Runtime.Serialization;
using Kl06.Eksempler.Modell;


namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;

    
    [DataContract (Name = "kompetansemaal-referanse")]
    public class Kompetansemål : Referanse
    {
        [DataMember(Name = "rekkefoelge")]
        [Description("Kompetansemålets rekkefølge i denne konteksten")]
        public int Rekkefølge { get; set; }

        [DataMember(Name = "tilhoerer-hovedomraade")]
        [Description("Kompetansemål plassert under hovedområde i denne konteksten")]
        public Base Hovedområde { get; set; }
    }
}