using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "eksamensforloep")]
    public class Eksamensforløp
    {
        [DataMember(Order = 0, Name = "eksamensforloep-type")]
        [Description("Type eksamenforløp")]
        public Kodeverkverdi EksamensforløpType { get; set; }

        [DataMember(Order = 1, Name = "semester-fra")]
        [Description("Semester fra")]
        public Kodeverkverdi SemesterFra { get; set; }

        [DataMember(Order = 2, Name = "semester-til")]
        [Description("Semester til")]
        public Kodeverkverdi SemesterTil { get; set; }
    }
}