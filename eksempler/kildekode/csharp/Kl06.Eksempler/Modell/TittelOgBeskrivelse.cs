using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract (Name = "tittel-og-beskrivelse")]
    public class TittelOgBeskrivelse
    {
        [DataMember(Order = 0, Name = "tittel")]
        [Description("Tittel)")]
        public List<Språkversjonert> Tittel { get; set; }

        [DataMember(Order = 0, Name = "beskrivelse")]
        [Description("Beskrivelse")]
        public List<Språkversjonert> Beskrivelse { get; set; }  
    }
}
