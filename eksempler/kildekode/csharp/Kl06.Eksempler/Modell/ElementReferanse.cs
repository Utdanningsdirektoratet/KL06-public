using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Obsolete("Har opprettet ny klasse som kan gjenbrukes")]
    [DataContract (Name = "elementreferanse")]
    public class ElementReferanse : Referanse
    {
        [DataMember(Order = 1, Name = "sist-endret")]
        [Description("Når elementet sist ble endret")]
        public DateTime? SistEndret { get; set; }

    }
}
