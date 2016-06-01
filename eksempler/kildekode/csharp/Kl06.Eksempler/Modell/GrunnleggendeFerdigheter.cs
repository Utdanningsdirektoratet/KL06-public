using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler.Modell
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract (Name = "grunnleggende-ferdigheter")]
    [Description("Grunnleggende ferdigheter-kapittelet")]
    public class GrunnleggendeFerdigheter
    {

        // Grunnleggende ferdigheter //
        [DataMember(Order = 15, Name = "overskrift")]
        [Description("Overskrift for grunnleggende ferdigheter-kapittelet")]
        public List<Språkversjonert> GrunnleggendeFerdigheterOverskrift { get; set; }

        [DataMember(Order = 16, Name = "beskrivelse")]
        [Description("Innledning til GRF-kapittelet")]
        public List<Språkversjonert> GrunnleggendeFerdigheterBeskrivelse { get; set; }

        [DataMember(Order = 17, Name = "muntlig")]
        [Description("Overskrift og teskt for grunnleggende ferdigheter(muntlig)")]
        public OverskriftOgTekst GrunnleggendeFerdigheterMuntlig { get; set; }

         [DataMember(Order = 19, Name = "skriftlig")]
        [Description("Overskrift og teskt for grunnleggende ferdigheter(skriftlig)")]
        public OverskriftOgTekst GrunnleggendeFerdigheterSkriftlig { get; set; }

        [DataMember(Order = 21, Name = "lese")]
        [Description("Overskrift og teskt for grunnleggende ferdigheter(lese)")]
        public OverskriftOgTekst GrunnleggendeFerdighetLese { get; set; }

        [DataMember(Order = 23, Name = "regne")]
        [Description("Overskrift og teskt for grunnleggende ferdigheter(å regne)")]
        public OverskriftOgTekst GrunnleggendeFerdighetRegne { get; set; }

        [DataMember(Order = 25, Name = "digitale-verktoey")]
        [Description("Overskrift og teskt for grunnleggende ferdigheter(bruk av digitale verktøy)")]
        public OverskriftOgTekst GrunnleggendeFerdighetDigitaleVerktøy { get; set; }

        [DataMember(Order = 27, Name = "fritekst")]
        [Description("Benyttes dersom fastsatt læreplantekst avviker fra det vanlige formatet for GRF-kapittelet. Dersom feltet er fylt ut, må det benyttes ved utskrift i stedet for de fem diskrete feltene med beskrivelser av GRF for å gjennskape fastsatt tekst")]
        public List<Språkversjonert> GrunnleggendeFerdigheterFritekst { get; set; }
    }
}
