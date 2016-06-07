namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    

    [DataContract (Name = "referanse-med-gyldighet")]
    [Description("En referanse som er gyldig innenfor gyldig-til og fra.")]
    public class ReferanseMedGyldighet : Referanse
    {
    
        [DataMember(Order = 2, Name = "gyldighet")]
        public ReferanseGyldighetsperiode Gyldighet { get; set; }


    }
}