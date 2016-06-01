using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
   
    [DataContract (Name = "laereplan-referanse")]
    [Description("Benyttes for å angi læreplan som kompetansemål er benyttet i")]
    public class LæreplanReferanse : ReferanseMedGyldighet
    {
        [DataMember(Order = 1, Name = "tilhoerende-kompetansemaalsett")]
        [Description("Angir hvilke kompetansemålsett vi kobler oss mot i den refererte læreplanen")]
        
        public List<Referanse> Kompetansemålsett { get; set; }
        

        //[DataMember(Order = 1, Name = "kompetansemaalsett")]
        //public List<KompetanseMålsettReferanseKm> KompetansemålSettReferanser { get; set; }

    }
}