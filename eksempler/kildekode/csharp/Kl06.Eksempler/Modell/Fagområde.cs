using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;


    [DataContract (Name = "fagomraade")]
    [Description("Kategorisering av fag etter innhold. Benyttes av statistikkavdelingen i Udir. Fagområder tilhører en fagkategori")]
    public class Fagområde : HovedElement
    {
        [DataMember(Order = 0, Name = "fagkategori")]
        [Description("Fagkategorien fagområdet tilhører")]
        public List<ReferanseMedGyldighet> Fagkategori { get; set; }	

    }
}
