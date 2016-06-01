using System;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract(Namespace = "http://psi.udir.no/lk06/2011/03")]
    public class Historikk
    {
        [DataMember]
        public string Bruker { get; set; }

        [DataMember]
        public DateTime Tidspunkt { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Kommentar { get; set; }

    }
}