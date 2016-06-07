using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{

using System.Collections.Generic;
using System.Runtime.Serialization;

    namespace Kl06.Eksempler.Modell
    {
        [DataContract (Name = "hovedomraade")]
        public class HovedområdeReferanseOpplærinsfag : BaseElement
        {

            /// <summary>
            /// Viser alternativ beskrivelse om tilgjengelig
            /// </summary>
            [DataMember(Order = 0, Name = "beskrivelse")]
            [Description("Hovedområdets beskrivelse")]
            public List<Språkversjonert> Beskrivelse { get; set; }


            [DataMember(Order = 1, Name = "kompetansemaal-for-opplaeringsfag")]
            [Description("Oversikt over tilknyttede kompetansemål")]
            public List<Kompetansemål> Kompetansemål { get; set; }

        }
    }
}