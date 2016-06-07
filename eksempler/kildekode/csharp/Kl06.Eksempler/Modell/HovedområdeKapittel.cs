using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    
    [DataContract (Name = "hovedomraade-kapittel")]
    [Description("hovedområdekapittel")]
    public class HovedområdeKapittel
    {
        // Hovedområder //
        [DataMember(Order = 28, Name = "overskrift")]
        [Description("Overskrift for hovedområdekapittelet")]
        public List<Språkversjonert> HovedområdeOverskrift { get; set; }

        [DataMember(Order = 29, Name = "innledning")]
        [Description("Innledning til hovedområdekapittelet")]
        public List<Språkversjonert> HovedområdeInnledning { get; set; }

        [DataMember(Order = 30, Name = "hovedomraader")]
        [Description("Liste over hovedområdene")]
        public List<Hovedområde> Hovedområder { get; set; }

        [DataMember(Order = 31, Name = "fritekst")]
        [Description("Benyttes dersom fastsatt læreplantekst avviker fra det vanlige formatet for hovedområdekapittelet. Dersom feltet er fylt ut, må det benyttes ved utskrift i stedet for de enkelte hovedområdebeskrivelsene for å gjenskape fastsatt tekst")]
        public List<Språkversjonert> HovedområdeFritekst { get; set; }
    }
}
