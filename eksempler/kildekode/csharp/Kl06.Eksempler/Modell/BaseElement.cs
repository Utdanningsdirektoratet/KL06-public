using System.ComponentModel;
using Kl06.Eksempler.Modell;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(Name = "baseelement")]
    public class BaseElement : Base
    {
        [DataMember(Order = 1, Name = "tittel")]
        public List<Språkversjonert> Tittel { get; set; }

        //TODO Til spørringene versjon 2.0
        [DataMember(Order = 2, Name = "status")]
        public Kodeverkverdi Status { get; set; }
    }
}
