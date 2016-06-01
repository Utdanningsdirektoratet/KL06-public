using System.ComponentModel;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Obsolete("Har opprettet ny klasse som kan gjenbrukes")]
    [DataContract (Name = "kjerneelementreferanse")]
    public class KjerneElementReferanse
    {
        [DataMember(Order = 0, Name = "id")]
        public string Id { get; set; }

        [DataMember(Order = 1, Name = "kode")]
        public string Kode { get; set; }

        [DataMember(Order = 2, Name = "url-data")]
        public string UrlData { get; set; }

        [DataMember(Order = 3, Name = "url-psi")]
        public string UrlPsi { get; set; }

        [DataMember(Order = 4, Name = "tittel")]
        [Description("Elementets navn")]
        public List<Språkversjonert> Tittel { get; set; }

        [DataMember(Order = 5, Name = "status")]
        public string Status { get; set; }

    }
}
