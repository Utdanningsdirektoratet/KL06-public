using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "diffkompetansemaal")]
    public class KompetansemålDifferanse
    {
        [DataMember(Order = 0, Name = "laereplan-a")]
        public Referanse GammelLæreplan { get; set; }

        [DataMember(Order = 1, Name = "laereplan-b")]
        public Referanse NyLæreplan { get; set; }

        [DataMember(Order = 2, Name = "kompetansemaal-kun-i-laereplan-a")]
        public List<Referanse> FjernetKompetansemål { get; set; }
        
        [DataMember(Order = 3, Name = "kompetansemaal-i-begge")]
        public List<Referanse> FellesKompetansemål { get; set; }

        [DataMember(Order = 4, Name = "kompetansemaal-kun-i-laereplan-b")]
        public List<Referanse> NyeKompetansemål { get; set; }

    }
}
