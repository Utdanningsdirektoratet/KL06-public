
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "hovedomraade")]
    public class Hovedområde : BaseElement
    {
        public Hovedområde()
        {
            UnderliggendeHovedområder = new List<Hovedområde>();
        }

        [DataMember(Name = "rekkefoelge")]
        [Description("Hovedområdets rekkefølge")]
        public int Rekkefølge { get; set; }

        [DataMember(Name = "beskrivelse")]
        [Description("Beskrivelse av hovedområdet")]
        public List<Språkversjonert> Beskrivelse { get; set; }

        [DataMember(Name = "underliggende-hovedomraader")]
        [Description("Liste over de underliggende hovedområdene")]
        public List<Hovedområde> UnderliggendeHovedområder { get; set; }
    }
}
