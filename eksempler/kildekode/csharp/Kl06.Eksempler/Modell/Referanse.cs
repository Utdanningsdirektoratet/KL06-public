using System.ComponentModel;



namespace Kl06.Eksempler.Modell
{
    using System.Runtime.Serialization;

    [DataContract (Name = "referanse")]
    public class Referanse : Base
    {
        [DataMember(Order = 1, Name = "tittel")]
        [Description("Elementets navn")]
        public string Tittel { get; set; }

        [DataMember(Order = 2, Name = "status")]
        public string Status { get; set; }

    }
}
