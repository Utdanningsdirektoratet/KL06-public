using System.ComponentModel;


namespace Kl06.Eksempler.Modell
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [DataContract (Name = "laereplan")]
    public class Læreplan : HovedElement
    {
        public Læreplan()
        {
            this.GrunnleggendeFerdigheter = new GrunnleggendeFerdigheter()
                {
                    GrunnleggendeFerdighetLese = new OverskriftOgTekst(),
                    GrunnleggendeFerdigheterSkriftlig = new OverskriftOgTekst(),
                    GrunnleggendeFerdighetRegne = new OverskriftOgTekst(),
                    GrunnleggendeFerdigheterMuntlig = new OverskriftOgTekst(),
                    GrunnleggendeFerdighetDigitaleVerktøy = new OverskriftOgTekst()
                };

            this.FastsettelsesInformasjon = new FastsettelsesInformasjon();
            this.Formål = new OverskriftOgTekst();
            this.StrukturFellesProgramfag = new OverskriftOgTekst();
            this.GyldighetsPeriode = new Gyldighetsperiode()
                {
                    GyldigFra = new OverskriftOgDato(),
                    GyldigTil = new OverskriftOgDato()
                };
            this.ProgramfagKapittel = new ProgramfagKapittel()
                {
                    Programfag = new List<Programfag>()
                };
            this.HovedområdeKapittel = new HovedområdeKapittel()
                {
                    Hovedområder = new List<Hovedområde>()                                 
                };
            this.KompetansemålKapittel = new KompetansemålKapittel()
                {
                    Kompetansemålsett = new List<Kompetansemålsett>()
                };
            this.Merkelapper = new List<Referanse>();
            this.Timetall = new OverskriftOgTekst();
            this.Vurdering = new OverskriftOgTekst();
        }

        [DataMember(Order = 0, Name = "fagtype")]
        [Description("Hvilken fagtype (eks. <i>fellesfag</i>) læreplanen (hovedsakelig) omhandler (utledes av tilkoblede fagkoder)")]
        public Kodeverkverdi Fagtype { get; set; }

        [DataMember(Order = 1, Name = "fastsettelsesinformasjon")]
        [Description("Fastsettelsesinformasjon")]
        public FastsettelsesInformasjon FastsettelsesInformasjon { get; set; }

        //[DataMember(Order = 2, Name = "er-oversettelse-teskt")]
        //[Description("Tekst for om dette er en oversettelse")]
        public List<Språkversjonert> ErOversettelseTekst { get; set; }

        [DataMember(Order = 2, Name = "gyldighetsperiode")]
        [Description("Gyldighetsperiode")]
        public Gyldighetsperiode GyldighetsPeriode { get; set; }

        [DataMember(Order = 6, Name = "erstatter")]
        [Description("Hvilke læreplaner denne læreplanen erstatter")]
        public List<Referanse> Erstatter { get; set; }

        [DataMember(Order = 7, Name = "erstattes-av")]
        [Description("Hvilke læreplaner denne læreplanen blir erstattet av")]
        public List<Referanse> ErstattetAv { get; set; }

        [DataMember(Order = 8, Name = "tilgjengelige-spraak")]
        [Description("Hvilke språk denne læreplanen er oversatt til")]
        public List<Kodeverkverdi> TilgjengeligeSpråk { get; set; }

        [DataMember(Order = 11, Name = "formaal-kapittel")]
        [Description("Overskrift og tekst for formålskapittelet")]
        public OverskriftOgTekst Formål { get; set; }
        
        [DataMember(Order = 11, Name = "timetall-kapittel")]
        [Description("Overskrift og tekst for timetallskapittelet")]
        public OverskriftOgTekst Timetall { get; set; }

        [DataMember(Order = 14, Name = "struktur-kapittel")]
        [Description("Overskrift og tekst for strukturkapittelet")]
        public OverskriftOgTekst StrukturFellesProgramfag { get; set; }

        [DataMember(Order = 14, Name = "grunnleggende-ferdigheter-kapittel")]
        [Description("Grunnleggende ferdigheter-kapittelet")]
        public GrunnleggendeFerdigheter GrunnleggendeFerdigheter { get; set; }
        
        [DataMember(Order = 14, Name = "programfag-kapittel")]
        [Description("Overskrift og innhold knyttet til programfag-kapittelet")]
        public ProgramfagKapittel ProgramfagKapittel { get; set; }

        [DataMember(Order = 14, Name = "hovedomraade-kapittel")]
        [Description("Overskrift og innhold knyttet til hovedomraade-kapittelet")]
        public HovedområdeKapittel HovedområdeKapittel { get; set; }

        [DataMember(Order = 32, Name = "kompetansemaal-kapittel")]
        [Description("Kompetansemål-kapittelet")]
        
        public KompetansemålKapittel KompetansemålKapittel { get; set; }

        [DataMember(Order = 36, Name = "vurdering-kapittel")]
        [Description("Overskrift og teskt for vurderingskapittelet")]
        public OverskriftOgTekst Vurdering { get; set; }

        [DataMember(Order = 38, Name = "merkelapper")]
        [Description("Merkelapper tilknyttet denne læreplanen (eks: lærlingeplan, for hørselshemmede, m.v.)")]
        public List<Referanse> Merkelapper { get; set; }

        [DataMember(Order = 39, Name = "opplaeringsnivaa")]
        [Description("Grunnskole og/eller videregående")]
        public List<Kodeverkverdi> Opplæringsnivå { get; set; }
        
        [DataMember(Order = 40, Name = "siste-eksamen")]
        [Description("Siste mulige eksamensdato")]
        public DateTime? SisteEksamen { get; set; }

        [DataMember(Order = 42, Name = "soekehjelp-navn-motsatt-maalform")]
        [Description("Søkestikkord på tvers av språk")]
        public string SøkeHjelpTekst { get; set; }

        //[DataMember(Order = 43, Name = "sorter-hovedomraader-under-programfag")]
        //[Description("Settes for læreplaner som omhandler flere separate fag (eks: POS1-01). Hovedområdene bør da sorteres under tilhørende programfag ved utskrift")]
        public bool? SorterHovedråderUnderProgramfag { get; set; }

        

        //[DataMember(Order = 44, Name = "er-beskrivelse-av-programfagene")]
        public bool? ErBeskrivelseAvProgramfagene { get; set; }

        [DataMember(Order = 46, Name = "tilleggsopplysninger")]
        [Description("Felt for å sette avanserte merknader tilknyttet en læreplan. Eksempelvis overgangsordninger, forsøk, o.l..")]
        public string Merknad { get; set; }

    }

}
