using System.ComponentModel;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;

    [DataContract (Name = "hjelpedataverdi")]
    [Description("Nøkkelverdi med tilhørende beskrivelse. Hjelpedata er en samlekategori for verdier som årstrinn, språk, vurderingsformer, eksamensordninger, m.v.")]
    public class Kodeverkverdi
    {
        //[DataMember(Order = 0, Name = "noekkel")]
        //[Description("Unik nøkkel for denne typen")]
        //public string Nøkkel { get; set; }

        [DataMember(Order = 0, Name = "uri")]
        [Description("Unik nøkkel for denne typen")]
        public string Uri { get; set; }

        [DataMember(Order = 5, Name = "grep-type")]
        public string GrepType { get; set; }


        [DataMember(Order = 1, Name = "beskrivelse")]
        [Description("Beskrivelse av uri")]
        public List<Språkversjonert> Beskrivelse { get; set; }
    }
}