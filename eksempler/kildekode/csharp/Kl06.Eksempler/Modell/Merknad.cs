using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    //

    [DataContract (Name = "merknad")]
    [Description("Elementer av typen «merknad» er standariserte fag- og vitnemålsmerknader som benyttes ved utskrift av dokumentasjon som kompetansebevis og vitnemål for å markere spesielle egenskaper ved enkelte fag eller dokumentet i sin helhet. Hver av merknadene har en egen FAM- eller VMM-kode, og tolkning og anvendelse er definert i skrivene om vitnemålsføring for grunnskole og videregående utdanning (http://www.udir.no/Vurdering/Vitnemal-og-kompetansebevis/).")]
    public class Merknad : HovedElement
    {
        [DataMember(Order = 0, Name = "kortform")]
        [Description("Forkortelse av merknad til bruk på dokumentasjon (vitnemålsmerknader forkortes ikke)")]
        public List<Språkversjonert> Kortform { get; set; }

        [DataMember(Order = 1, Name = "merknads-type")]
        [Description("Vitnemålsmerknad/fagmerknad")]
        public Kodeverkverdi TypeMerknad { get; set; }

        [DataMember(Order = 1, Name = "gyldig-fra")]
        [Description("Gyldig fra")]
        public DateTime? GyldigFra { get; set; }

        [DataMember(Order = 2, Name = "gyldig-til")]
        [Description("Gyldig til")]
        public DateTime? GyldigTil { get; set; }

        [DataMember(Order = 6, Name = "opplaeringsnivaa")]
        public List<Kodeverkverdi> Opplæringsnivå { get; set; }

        [DataMember(Order = 7, Name = "dokumenttype")]
        public List<Kodeverkverdi> Dokumenttype { get; set; }

        [DataMember(Order = 8, Name = "relaterte-fag")]
        public List<Referanse> ReleaterteFag { get; set; }

        [DataMember(Order = 9, Name = "relaterte-aarstrinn")]
        public List<Kodeverkverdi> RelaterteÅrstrinn { get; set; }
    }
}
