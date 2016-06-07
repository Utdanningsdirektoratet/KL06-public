namespace Kl06.Eksempler.Modell
{
    using System;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract (Name = "gyldighetsperiode-for-referanse")]
    [Description("Gyldighetsperiode for en referanse")]
    public class ReferanseGyldighetsperiode
    {

        [DataMember(Order = 1, Name = "gyldig-fra")]
        [Description("Gyldig fra")]
        public DateTime? GyldigFra { get; set; }


        [DataMember(Order = 2, Name = "gyldig-til")]
        [Description("Gyldig til")]
        public DateTime? GyldigTil { get; set; }


    }
}