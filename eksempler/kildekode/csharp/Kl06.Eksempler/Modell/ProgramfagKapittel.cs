using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract (Name = "programfag-kapittel")]
    [Description("Programfagkapittel")]
    public class ProgramfagKapittel
    {
        // Hovedområder //
        [DataMember(Order = 28, Name = "overskrift")]
        [Description("Overskrift for programfag-kapittelet")]
        public List<Språkversjonert> Overskrift { get; set; }

        [DataMember(Order = 30, Name = "programfag")]
        [Description("Liste over program")]
        public List<Programfag> Programfag { get; set; }
    }
}
