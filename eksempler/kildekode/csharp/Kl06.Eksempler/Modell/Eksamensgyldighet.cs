using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    // Brukes fortsatt for å unngå kontraktsbrudd
    [DataContract (Name = "eksamensgyldighet")]
    public class Eksamensgyldighet
    {
        [DataMember(Order = 0, Name = "foerste-semester")]
        [Description("Første semester")]
        public Kodeverkverdi FørsteSemester { get; set; }

        [DataMember(Order = 1, Name = "siste-semester")]
        [Description("Siste semester")]
        public Kodeverkverdi SisteSemester { get; set; }

        [DataMember(Order = 2, Name = "semester-uten-eksamen")]
        [Description("Feltet benyttes ikke i KL06. Gjennomføring av eksamen i Kunnskapsløftet håndteres i PAS/PGS")]
        [Obsolete]
        public List<Kodeverkverdi> SemesterUtenEksamen { get; set; }
    }
}