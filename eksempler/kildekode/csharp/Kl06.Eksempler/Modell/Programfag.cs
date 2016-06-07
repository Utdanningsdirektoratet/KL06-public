
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    
    [DataContract (Name = "programfag")]
    public class Programfag : BaseElement
    {
        public Programfag()
        {
            Hovedområder = new List<Hovedområde>();
        }
         
        [DataMember(Name = "rekkefoelge")]
        [Description("Programfagets rekkefølge")]
        public int Rekkefølge { get; set; }

        [DataMember(Name = "beskrivelse")]
        [Description("Beskrivelse av programfaget")]
        public List<Språkversjonert> Beskrivelse { get; set; }

        [DataMember(Name = "underliggende-hovedomraader")]
        [Description("Liste over de underliggende hovedområder")]
        public List<Hovedområde> Hovedområder { get; set; }
    }
}
