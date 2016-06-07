using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract (Name = "hovedelement")]
    public class HovedElement : BaseElement
    {
        [DataMember(Order = 2, Name = "sist-endret")]
        [Description("Dato elementet sist ble endret")]
        public DateTime? SistEndret { get; set; }
    }
}
