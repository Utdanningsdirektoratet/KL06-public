using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{
    
    using System.Runtime.Serialization;

    [DataContract (Name = "spraakversjonert")]
    [Description("Elementer der verdiene er oversatt til flere språk")]
    public class Språkversjonert
    {
        //[Description("Språk for oversettelse. Følger ISO 639 (se <a href=\"http://psi.oasis-open.org/iso/639/\">Published subjects for languages in ISO 639</a>). Nøkkel <i>default</i> angir standard oversettelse for dette elementet")]
        //[DataMember(Order = 0, Name = "noekkel")]
        //public string Nøkkel { get; set; }

        [Description("Språk for oversettelse. Følger ISO 639 (se <a href=\"http://psi.oasis-open.org/iso/639/\">Published subjects for languages in ISO 639</a>). Språk <i>default</i> angir standard oversettelse for dette elementet")]
        [DataMember(Order = 1, Name = "spraak")]
        public string Språk { get; set; }
            
        [Description("Oversettelse")]
        [DataMember(Order = 2, Name = "verdi")]
        public string Verdi { get; set; }
    }
}