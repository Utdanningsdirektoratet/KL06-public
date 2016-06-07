using System.ComponentModel;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract (Name = "gyldighetsperiode")]
    public class Gyldighetsperiode
    {

        [DataMember(Order = 1, Name = "gyldig-fra")]
        [Description("Gyldig fra")]
        public OverskriftOgDato GyldigFra { get; set; }


        [DataMember(Order = 2, Name = "gyldig-til")]
        [Description("Gyldig til")]
        public OverskriftOgDato GyldigTil { get; set; }

    }
}
