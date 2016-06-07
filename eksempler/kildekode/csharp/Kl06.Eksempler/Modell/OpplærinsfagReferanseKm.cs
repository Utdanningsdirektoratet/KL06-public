using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{
    [Obsolete("Har opprettet ny klasse som kan gjenbrukes")]
    [DataContract (Name = "opplaeringsfag")]
    public class OpplærinsfagReferanseKm : Referanse
    {
        [DataMember(Order = 0, Name = "kortform")]
        public List<Språkversjonert> Kortform { get; set; }

    }
}