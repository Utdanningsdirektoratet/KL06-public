using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    
    [DataContract (Name = "opplaeringsfag")]
    [Description("Benyttes for å koble kompetansemålsett mot fagkoder. Et opplæringsfag tilsvarer som oftest en variant av hvordan opplæring er organisert (derav navnet). Det finnes noen unntak, hovedsakelig i språkfagene")]
    public class Opplæringsfag : Fag
    {
        [DataMember(Order = 1, Name = "fagtype")]
        [Description("Eks. fellesfag, valgfritt programfag")]
        public Kodeverkverdi Fagtype { get; set; }

        [DataMember(Order = 2, Name = "opplaeringsnivaa")]
        [Description("Grunnskole/videregående opplæring")]
        public Kodeverkverdi Opplæringsnivå { get; set; }

        [DataMember(Order = 3, Name = "tilleggsopplysninger")]
        [Description("Evt. ekstra informasjon eller presiseringer for dette opplæringsfaget. Må ikke forveksles med datatypen «merknad»")]
        public List<Språkversjonert> Tilleggsopplysninger { get; set; }

        [DataMember(Order = 4, Name = "programomraader-referanse")]
        [Description("Hvilke programområder har denne opplæringen (foreløpig kun benyttet for programfag i yrkesfagene)")]
        public List<ReferanseMedGyldighet> ProgramområdeReferanser { get; set; }

        [DataMember(Order = 7, Name = "laereplan-referanse")]
        [Description("Lenke til hvor innholdet i faget er bestemt")]
        public List<LæreplanReferanse> LæreplanReferanser { get; set; }

        [DataMember(Order = 8, Name = "merkelapper")]
        [Description("Eks. <i>særløp</i>")]
        
        public List<Referanse> Merkelapper { get; set; }

        [DataMember(Order = 9, Name = "bygger-paa-fag")]
        [Description("Oversikt over hvilket opplæringsfag dette opplæringsfaget bygger på")]
        public List<Referanse> ByggerPåFag { get; set; }

        [DataMember(Order = 11, Name = "fagkode-referanser")]
        [Description("Hvilke fagkoder benyttes til dokumentasjon ")]
        public List<ReferanseMedGyldighet> FagkodeReferanse { get; set; }

        [DataMember(Order = 12, Name = "fagomraade-referanser")]
        [Description("Kategorisering av hva innholdet i faget er. (foreløpig kun benyttet i studieforberende utdanning og grunnskolen) ")]
       public List<Referanse> FagområdeReferanse { get; set; }

        [DataMember(Order = 12, Name = "fortsetter-opplaering-i-samme-kompetansemaalsett-som")]
        [Description("Fortsetter opplæring i samme kompetansemålsett som")]
        public List<ReferanseMedGyldighet> FortsettOpplæringenISammeKompetansemålsettSom { get; set; }

        [DataMember(Order = 13, Name = "kortform")]
        [Description("Fagets oversatte kortformer (lite brukt)")]
        public new List<Språkversjonert> Kortform { get { return base.Kortform; } set { base.Kortform = value; } }

        [DataMember(Order = 14, Name = "erstatter")]
        [Description("hvilke opplæringsfag dette erstatter")]
        public new List<Referanse> Erstatter { get { return base.Erstatter; } set { base.Erstatter = value; } }

        [DataMember(Order = 15, Name = "erstattes-av")]
        [Description("hvilke opplæringsfag dette blir erstattet av")]
        public new List<Referanse> ErstattesAv { get { return base.ErstattesAv; } set { base.ErstattesAv = value; } }
    }
}