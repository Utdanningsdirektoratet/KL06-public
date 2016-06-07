namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract (Name = "opplaeringsnivaa")]
    public class Opplæringsnivå
    {
        [DataMember(Order = 0, Name = "opplaeringsnivaa-type")]
        public List<Språkversjonert> OpplæringsnivåType { get; set; }
    }
}
