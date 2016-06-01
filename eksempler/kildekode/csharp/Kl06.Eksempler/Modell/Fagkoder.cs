using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace Kl06.Eksempler.Modell
{

    [DataContract (Name = "fagkode")]
    public class Fagkoder : Fag
    {

        public Fagkoder()
        {
            Vurdering = new List<Vurdering>();
            Erstatter = new List<Referanse>();
            ErstattesAv = new List<Referanse>();
            BenyttesSammenMed = new List<Referanse>();
            ByggerPåFag = new List<Referanse>();
            Merkelapper = new List<Referanse>(); 
        }

        [DataMember(Order = 1, Name = "erstatter")]
        [Description("hvilken fagkode denne fagkoden erstatter")]
        public new List<Referanse> Erstatter { get { return base.Erstatter; } set { base.Erstatter = value; } }

        [DataMember(Order = 2, Name = "erstattes-av")]
        [Description("hvilke fagkode denne fagkoden blir erstattet av")]
        public new List<Referanse> ErstattesAv { get { return base.ErstattesAv; } set { base.ErstattesAv = value; } }

        [DataMember(Order = 1, Name = "fagtype")]
        [Description("Fagtype")]
        public Kodeverkverdi Fagtype { get; set; }

        [DataMember(Order = 2, Name = "opplaeringsnivaa")]
        [Description("Opplæringsnivå")]
        public Kodeverkverdi Opplæringsnivå { get; set; }

        [DataMember(Order = 4, Name = "omfang-totalt")]
        [Description("Totalt omfang timer som settes på vitnemålet")]
        public string OmfangTotalt { get; set; }

        [DataMember(Order = 4, Name = "omfang-vitnemaal")]
        [Description("Totalt omfang timer som settes på vitnemålet")]
        public string OmfangVitnemål { get; set; }

        // Erstatter OmfangTotalt
        [DataMember(Order = 5, Name = "omfang-til-naa")]
        [Description("Omfang dersom flerårig fag avsluttes på dette nivået")]
        public string OmfangTilNå { get; set; }

        [DataMember(Order = 7, Name = "opplaeringsfag")]
        [Description("Opplæringsfag denne fagkoden tilhører")]
        public List<ReferanseMedGyldighet> Opplæringsfag { get; set; }

        [DataMember(Order = 8, Name = "naar-kan-man-ta-eksamen")]
        [Description("Spesifiserer i hvilken periode man kan ta eksamen")]
        public Eksamensgyldighet NårKanManTaEksamen { get; set; }

        [DataMember(Order = 9, Name = "naar-gis-det-undervisning")]
        [Description("Spesifiserer i hvilken periode undervisning gis")]
        public Semesterperiode NårGisUndervisning { get; set; }

        [DataMember(Order = 11, Name = "vurderingsordning")]
        [Description("Vurderingsordning")]
        public List<Vurdering> Vurdering { get; set; }

        [DataMember(Order = 12, Name = "sensur")]
        [Description("Sensurordning")]
        public Kodeverkverdi Sensur { get; set; }

        [DataMember(Order = 13, Name = "oppgave")]
        [Description("Om oppgaven utarbeides sentralt eller lokalt")]
        public Kodeverkverdi Oppgave { get; set; }

        [DataMember(Order = 14, Name = "tilleggsopplysninger")]
        [Description("Evt. ekstra informasjon eller presiseringer for denne fagkoden. Må ikke forveksles med datatypen «merknad»")]
        public List<Språkversjonert> Tilleggsopplysninger { get; set; }

        [DataMember(Order = 16, Name = "bygger-paa-fag")]
        [Description("Oversikt over hvilke fagkoder denne fagkoden bygger på")]
        public List<Referanse> ByggerPåFag { get; set; }

        [DataMember(Order = 16, Name = "benyttes-sammen-med")]
        [Description("Angir andre fagkoder som sammen med denne utgjør en samlet vurdering i et fag. Eksempelvis muntlig og skriftlig fagkode for samme opplæring")]
        public List<Referanse> BenyttesSammenMed { get; set; }

        [DataMember(Order = 18, Name = "merkelapper")]
        [Description("Merkelapper tilknyttet fagkoden")]
        public List<Referanse> Merkelapper { get; set; }

        [DataMember(Order = 1, Name = "gyldig-fra")]
        [Description("Gyldig fra")]
        public DateTime? GyldigFra { get; set; }

        [DataMember(Order = 2, Name = "gyldig-til")]
        [Description("Gyldig til")]
        public DateTime? GyldigTil { get; set; }

    }
}