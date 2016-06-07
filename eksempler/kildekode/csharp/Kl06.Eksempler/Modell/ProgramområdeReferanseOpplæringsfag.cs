using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "prograomraade-referanse-opplaeringsfag")]
    public class Programomr�deReferanseOppl�ringsfag : Referanse
    {
        //[DataMember(Order = 1, Name = "aarstimer")]
        //public string �rstimer { get; set; }

        //[DataMember(Order = 2, Name = "aarstimer-samisk")]
        //public string �rstimerSamisk { get; set; }

        //[DataMember(Order = 3, Name = "aarstimer-doeve-og-tunghoerte")]
        //public string �rstimerD�veOgTungh�rte { get; set; }

        //[DataMember(Order = 4, Name = "aarstimer-formgivningsfag")]
        //public string �rstimerFormgivningsfag { get; set; }

        //[DataMember(Order = 5, Name = "tilknyttede-utdanningsprogram")]
        //public List<Referanse> TilknyttedeUtdanningsprogram { get; set; }
    }
}