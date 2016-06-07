using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "semesterperiode")]
    public class Semesterperiode
    {
        [DataMember(Order = 0, Name = "foerste-semester")]
        public Kodeverkverdi FørsteSemester { get; set; }

        [DataMember(Order = 1, Name = "siste-semester")]
        public Kodeverkverdi SisteSemester { get; set; }
    }
}