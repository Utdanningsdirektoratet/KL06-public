using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    
    [DataContract (Name = "opplaeringsfag")]
    [Description("Benyttes for � koble kompetansem�lsett mot fagkoder. Et oppl�ringsfag tilsvarer som oftest en variant av hvordan oppl�ring er organisert (derav navnet). Det finnes noen unntak, hovedsakelig i spr�kfagene")]
    public class Oppl�ringsfag : Fag
    {
        [DataMember(Order = 1, Name = "fagtype")]
        [Description("Eks. fellesfag, valgfritt programfag")]
        public Kodeverkverdi Fagtype { get; set; }

        [DataMember(Order = 2, Name = "opplaeringsnivaa")]
        [Description("Grunnskole/videreg�ende oppl�ring")]
        public Kodeverkverdi Oppl�ringsniv� { get; set; }

        [DataMember(Order = 3, Name = "tilleggsopplysninger")]
        [Description("Evt. ekstra informasjon eller presiseringer for dette oppl�ringsfaget. M� ikke forveksles med datatypen �merknad�")]
        public List<Spr�kversjonert> Tilleggsopplysninger { get; set; }

        [DataMember(Order = 4, Name = "programomraader-referanse")]
        [Description("Hvilke programomr�der har denne oppl�ringen (forel�pig kun benyttet for programfag i yrkesfagene)")]
        public List<ReferanseMedGyldighet> Programomr�deReferanser { get; set; }

        [DataMember(Order = 7, Name = "laereplan-referanse")]
        [Description("Lenke til hvor innholdet i faget er bestemt")]
        public List<L�replanReferanse> L�replanReferanser { get; set; }

        [DataMember(Order = 8, Name = "merkelapper")]
        [Description("Eks. <i>s�rl�p</i>")]
        
        public List<Referanse> Merkelapper { get; set; }

        [DataMember(Order = 9, Name = "bygger-paa-fag")]
        [Description("Oversikt over hvilket oppl�ringsfag dette oppl�ringsfaget bygger p�")]
        public List<Referanse> ByggerP�Fag { get; set; }

        [DataMember(Order = 11, Name = "fagkode-referanser")]
        [Description("Hvilke fagkoder benyttes til dokumentasjon ")]
        public List<ReferanseMedGyldighet> FagkodeReferanse { get; set; }

        [DataMember(Order = 12, Name = "fagomraade-referanser")]
        [Description("Kategorisering av hva innholdet i faget er. (forel�pig kun benyttet i studieforberende utdanning og grunnskolen) ")]
       public List<Referanse> Fagomr�deReferanse { get; set; }

        [DataMember(Order = 12, Name = "fortsetter-opplaering-i-samme-kompetansemaalsett-som")]
        [Description("Fortsetter oppl�ring i samme kompetansem�lsett som")]
        public List<ReferanseMedGyldighet> FortsettOppl�ringenISammeKompetansem�lsettSom { get; set; }

        [DataMember(Order = 13, Name = "kortform")]
        [Description("Fagets oversatte kortformer (lite brukt)")]
        public new List<Spr�kversjonert> Kortform { get { return base.Kortform; } set { base.Kortform = value; } }

        [DataMember(Order = 14, Name = "erstatter")]
        [Description("hvilke oppl�ringsfag dette erstatter")]
        public new List<Referanse> Erstatter { get { return base.Erstatter; } set { base.Erstatter = value; } }

        [DataMember(Order = 15, Name = "erstattes-av")]
        [Description("hvilke oppl�ringsfag dette blir erstattet av")]
        public new List<Referanse> ErstattesAv { get { return base.ErstattesAv; } set { base.ErstattesAv = value; } }
    }
}