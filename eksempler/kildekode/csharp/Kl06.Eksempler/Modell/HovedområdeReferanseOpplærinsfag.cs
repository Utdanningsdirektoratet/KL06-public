using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{

using System.Collections.Generic;
using System.Runtime.Serialization;

    namespace Kl06.Eksempler.Modell
    {
        [DataContract (Name = "hovedomraade")]
        public class Hovedomr�deReferanseOppl�rinsfag : BaseElement
        {

            /// <summary>
            /// Viser alternativ beskrivelse om tilgjengelig
            /// </summary>
            [DataMember(Order = 0, Name = "beskrivelse")]
            [Description("Hovedomr�dets beskrivelse")]
            public List<Spr�kversjonert> Beskrivelse { get; set; }


            [DataMember(Order = 1, Name = "kompetansemaal-for-opplaeringsfag")]
            [Description("Oversikt over tilknyttede kompetansem�l")]
            public List<Kompetansem�l> Kompetansem�l { get; set; }

        }
    }
}