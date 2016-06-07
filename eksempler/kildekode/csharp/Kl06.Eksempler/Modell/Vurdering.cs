using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "vurderingsordning")]
    public class Vurdering
    {
        [DataMember(Order = 0, Name = "elevtype")]
        [Description("Angir hvilken type elev vurderingen gjelder for.")]
        // TODO public Kodeverkverdi Elevtype { get; set; }
        public string Elevtype { get; set; }

        [DataMember(Order = 0, Name = "standpunktvurdering")]
        [Description("Om det gis en standpunktvurdering tilknyttet denne fagkoden.")]
        public bool Standpunktvurdering { get; set; }

        [DataMember(Order = 1, Name = "hoeyeste-nivaa")]
        [Description("Om dette regnes som høyeste nivå for noen eller alle fagkoden gjelder for.")]
        public bool HøyesteNivå { get; set; }

        //Erstatter type-eksamensfag
        [DataMember(Order = 2, Name = "trekkordning")]
        [Description("Om faget er trekkfag eller om det er obligatorisk eksamen.")]
        public Kodeverkverdi Trekkordning { get; set; }

        //Erstatter type eksamensordning
        [DataMember(Order = 3, Name = "type-eksamensordning")]
        [Description("Eksamensordning for faget, slik den er beskrevet i læreplanen. Eks: «Skriftlig+muntlig praktisk». Eksamensordningen kan diktere at faget skal ha flere fagkoder, hvorav denne er en av disse. ")]
        public Kodeverkverdi Eksamensordning { get; set; }

        //Vurderingsform
        [DataMember(Order = 0, Name = "vurderingsuttrykk")]
        [Description("Om det gis tallkarakterer eller om det skal benyttes andre vurderingsuttrykk.")]
        public Kodeverkverdi VurderingsUttrykk { get; set; }

        [DataMember(Order = 0, Name = "eksamensform-paa-vitnemaalet")]
        [Description("Eksamensform for denne fagkoden, utledes av eksamensordning (se over). Eks: «Skriflig» eller «Muntlig praktisk».")]
        public Kodeverkverdi Eksamensform { get; set; }

    }
}