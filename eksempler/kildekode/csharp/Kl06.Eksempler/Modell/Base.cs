using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract(Name = "base")]
    public class Base
    {
        //[DataMember(Order = 0, Name = "id")]
        //[Description(KommentarKonstanter.PsiFelt)]
        //public string Id { get; set; }

        [DataMember(Order = 1, Name = "kode")]
        
        public string Kode { get; set; }

        [DataMember(Order = 2, Name = "url-data")]
        public string UrlData { get; set; }

        //[DataMember(Order = 3, Name = "url-psi")]
        //[Description(KommentarKonstanter.UrlPsiFelt)]
        //public string UrlPsi { get; set; }

        [DataMember(Order = 4, Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Order = 5, Name = "grep-type")]
        public string GrepType { get; set; }

    }
}
