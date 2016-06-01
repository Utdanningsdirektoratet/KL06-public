using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "merkelapp")]
    public class Merkelapp:HovedElement
    {
        [DataMember(Order = 0, Name = "kan-knyttes-til-fag")]
        [Description("Om merkelappen kan knyttes til fag")]
        public bool? KanKnyttesTilFag { get; set; }

        [DataMember(Order = 1, Name = "kan-knyttes-til-laereplan")]
        [Description("Om merkelappen kan knyttes til læreplan")]
        public bool? KanKnyttesTilLæreplan { get; set; }

        [DataMember(Order = 2, Name = "kan-knyttes-til-programomraade")]
        [Description("Om merkelappen kan knyttes til programområder")]
        public bool? KanKnyttesTilProgramområde { get; set; }

        [DataMember(Order = 3, Name = "tilknyttede-fag")]
        [Description("Fag hvor denne merkelappen blir benyttet")]
        public List<Referanse> TilknyttedeFag { get; set; }

        [DataMember(Order = 3, Name = "tilknyttede-laereplaner")]
        [Description("Læreplaner hvor denne merkelappen blir benyttet")]
        public List<Referanse> TilknyttedeLæreplaner { get; set; }

        [DataMember(Order = 3, Name = "tilknyttede-programomraader")]
        [Description("Programområder hvor denne merkelappen blir benyttet")]
        public List<Referanse> TilknyttedeProgramområder { get; set; }
    }
}