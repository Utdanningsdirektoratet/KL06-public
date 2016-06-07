using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "utdanningsprogram")]
    public class Utdanningsprogram : HovedElement
    {
        [DataMember(Order = 0, Name = "kortform")]
        [Description("Kortform av tittel.")]
        public List<Språkversjonert> Kortform { get; set; }

        [DataMember(Order = 1, Name = "type-utdanningsprogram")]
        [Description("Studieforberedende eller yrkesfaglig.")]
        public Kodeverkverdi TypeUtdanningsprogram { get; set; }

        [DataMember(Order = 2, Name = "tilleggsopplysninger")]
        [Description("Benyttes dersom det er spesieller merknader til elementet.")]
        public List<Språkversjonert> Tilleggsopplysninger { get; set; }

        [DataMember(Order = 3, Name = "erstatter")]
        [Description("Dersom utdanningsprogrammet erstatter et tidligere utd.prg.")]
        public List<Referanse> Erstatter { get; set; }

        [DataMember(Order = 15, Name = "erstattes-av")]
        [Description("hvilke utdanningprogram dette blir erstattet av")]
        public List<Referanse> ErstattesAv { get; set; }

        [DataMember(Order = 4, Name = "foerste-semester")]
        [Description("Når utd. prg. ble en del av tilbudsstrukturen.")]
        public Kodeverkverdi FørsteSemester { get; set; }

        [DataMember(Order = 5, Name = "siste-semester")]
        [Description("Siste gang utd. prg. var en del av tilbudsstrukturen.")]
        public Kodeverkverdi SisteSemester { get; set; }
    }
}
