using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "kompetansemaal")]
    public class KompetansemålKm : HovedElement
    {
        [DataMember(Order = 0, Name = "laereplan-referanser")]
        [Description("Liste over hvilke læreplaner som bruker dette kompetansemålet")]
        public List<LæreplanReferanse> LæreplanReferanser { get; set; }
    }
}
