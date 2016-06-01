using System.ComponentModel;

namespace Kl06.Eksempler.Modell
{
    using System.Collections.Generic;
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Serialization;

    
    [DataContract (Name = "programomraade")]
    public class Programområde : HovedElement
    {
        public Programområde()
        {
            ByggerPå = new List<ReferanseMedGyldighetsperiodeOgLøpstype>();
         //   TFTRelatertInformasjon = new TFTInformasjon();
            UtdanningsprogramReferanse = new List<ReferanseMedGyldighet>();
            Erstatter = new List<Referanse>();
            ErstattesAv = new List<Referanse>();
            Merkelapper = new List<Referanse>();
        }

        [DataMember(Order = 0, Name = "kortform")]
        [Description("Forkortelse av navnet til bruk i dokumentasjon")]
        public List<Språkversjonert> Kortform { get; set; }

        [DataMember(Order = 1, Name = "nasjonal-variant")]
        [Description("Ikke benyttet. Feltet vil bli fjernet.")]
        public string NasjonalVariant { get; set; }

        [DataMember(Order = 2, Name = "landslinje")]
        [Description("Landslinjer finansieres av staten. Søkere fra hele landet stiller likt.")]
        public bool LandsLinje { get; set; }

        [DataMember(Order = 3, Name = "landsdekkende-linje")]
        [Description("Landsdekkende linjer finansieres av fylkeskommunene. Søkere fra hele landet stiller likt.")]
        public bool LandsdekkendeLinje { get; set; }

        [DataMember(Order = 4, Name = "programomraade-type")]
        [Description("Angir modell; særløp, skole (elev) eller bedrift (lærling)")]
        public string ProgramområdeType { get; set; }

        [DataMember(Order = 5, Name = "aarstimer")]
        [Description("Ordinært omfang ihht fag- og timefordeling")]
        public string Årstimer { get; set; }

        [DataMember(Order = 6, Name = "aarstimer-samisk")]
        [Description("Omfang for de som følger Kunnskapsløftet samisk")]
        public string ÅrstimerSamisk { get; set; }

        [DataMember(Order = 7, Name = "aarstimer-doeve-og-tunghoerte")]
        [Description("Omfang ihht fag- og timefordeling for hørselshemmede")]
        public string ÅrstimerDøveOgTunghørte { get; set; }

        [DataMember(Order = 8, Name = "aarstimer-formgivningsfag")]
        [Description("Omfang i studiespesialisering for elever som har studs. spes med formgiving på Vg1")]
        public string ÅrstimerFormgivningsfag { get; set; }

        [DataMember(Order = 9, Name = "tilleggsopplysninger")]
        [Description("Evt. merknader eller beskrivelser av programområdet. Må ikke forveksles med datatypen «merknader»")]
        public List<Språkversjonert> Tilleggsopplysninger { get; set; }

        [DataMember(Order = 10, Name = "merkelapper")]
        [Description("Eks.: «særløp», «for privatskoler»")]
        public List<Referanse> Merkelapper { get; set; }

        [DataMember(Order = 11, Name = "foerste-semester")]
        [Description("Når programområdet ble en del av tilbudsstrukturen")]
        public Kodeverkverdi FørsteSemester { get; set; }

        [DataMember(Order = 12, Name = "siste-semester")]
        [Description("Siste gang programområdet var en del av tilbudsstrukturen")]
        public Kodeverkverdi SisteSemester { get; set; }

        [DataMember(Order = 13, Name = "aarstrinn")]
        [Description("Vg1, Vg2, Vg3 eller opplæring i bedrift (for programområder som har opplæring i bedrift etter 3 år i skole)")]
        public Referanse Årstrinn { get; set; }

        [DataMember(Order = 14, Name = "bygger-paa-programomraade")]
        [Description("Angir hvilket programområde dette programområdet bygger på")]
        public List<ReferanseMedGyldighetsperiodeOgLøpstype> ByggerPå { get; set; }

        [DataMember(Order = 15, Name = "erstatter")]
        [Description("Angir tidligere programområde som blir erstattet av dette programområdet")]
        public List<Referanse> Erstatter { get; set; }

        [DataMember(Order = 15, Name = "erstattes-av")]
        [Description("hvilke programområde dette blir erstattet av")]
        public List<Referanse> ErstattesAv { get; set; }

        [DataMember(Order = 16, Name = "utdanningsprogram-referanse")]
        [Description("Angir hvilket utdanningsprogram dette programområdet er en del av")]
        public List<ReferanseMedGyldighet> UtdanningsprogramReferanse { get; set; }

        [DataMember(Order = 18, Name = "yrkestittel")]
        public List<Språkversjonert> Yrkestittel { get; set; }

        [DataMember(Order = 19, Name = "opplaeringssted")]
        public List<Kodeverkverdi> Opplæringssted { get; set; }

        [DataMember(Order = 20, Name = "sluttkompetanse")]
        public List<Kodeverkverdi> Sluttkompetanse { get; set; }

        [DataMember(Order = 21, Name = "opplaeringstid")]
        public string Opplæringstid { get; set; }

        [DataMember(Order = 22, Name = "verdiskapingstid")]
        public string Verdiskapingstid { get; set; }

        //[DataMember(Order = 22, Name = "TFT-relatert-informasjon")]
        //public TFTInformasjon TFTRelatertInformasjon { get; set; }
    }
}