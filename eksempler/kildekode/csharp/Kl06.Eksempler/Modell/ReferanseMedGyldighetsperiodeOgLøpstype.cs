using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "referanse-med-gyldighetsperiode-og-loepstype")]
    public class ReferanseMedGyldighetsperiodeOgLøpstype:ReferanseMedGyldighet
    {
        [DataMember(Order = 1, Name = "loepstype")]
        [Description("Løpstype")]
        public Kodeverkverdi Løpstype { get; set; }
    }
}
