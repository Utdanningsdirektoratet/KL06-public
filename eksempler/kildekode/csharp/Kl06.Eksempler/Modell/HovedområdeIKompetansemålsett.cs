using System.ComponentModel;
using System.Runtime.Serialization;
using Kl06.Eksempler.Modell;

namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;

    /// <summary>
    /// Hovedområde i spørringsmodellen er alltid i kontekst av et kompetansemålsett, dvs med alternative navn etc
    /// </summary>
    [DataContract (Name = "hovedomraade-i-kontekst-av-kompetansemaalsett")]
    public class HovedområdeIKompetansemålsett: Base
    {

        public HovedområdeIKompetansemålsett()
        {
            //this.Hovedområder = new List<Base>();
            this.HovedområderVerdier = new TittelOgBeskrivelse(); 
        }

        //[DataMember(Order = 3, Name = "hovedomraader")]
        //[Description("Hovedområder som dekkes i kompetansemålsettet")]
        //public List<Base> Hovedområder { get; set; }
        /// <summary>
        /// Viser alternativ tittel og beskrivelse om tilgjengelig
        /// </summary>
        [DataMember(Order = 0, Name = "hovedomraadeverdier-under-kompetansemaalsett")]
        [Description("Tittel og beskrivelse av hovedområdet (i kontekst av det kompetansemålsettet det står i)")]
        public TittelOgBeskrivelse HovedområderVerdier { get; set; }   
    }
}