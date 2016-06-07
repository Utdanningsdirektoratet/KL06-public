using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Kl06.Eksempler.Modell;

namespace Kl06.Eksempler.Modell
{
    using System;

    
    [DataContract (Name = "kompetansemaalsett")]
    public class Kompetansemålsett : BaseElement
    {
        public Kompetansemålsett()
        {
            this.HovedområderIKontekstAvKompetansemålsett = new List<HovedområdeIKompetansemålsett>();
            this.Kompetansemål = new List<Kompetansemål>(); 
        }

        [DataMember(Order = 34, Name = "maal-for-kompetansemaalene-overskrift")]
        [Description("Varierer mellom elev- og lærlingeplaner")]
        public List<Språkversjonert> MålForKompetansemåleneOverskrift { get; set; }

        [DataMember(Order = 0, Name = "rekkefoelge")]
        [Description("Kompetansemålsettets rekkefølge i læreplanen")]
        public int Rekkefølge { get; set; }

        [DataMember(Order = 3, Name = "programfag")]
        [Description("Tilhørende programfag")]

        public Base TilhørendeProgramfag { get; set; }

        [DataMember(Order = 3, Name = "hovedomraader-i-kontekst-av-kompetansemaalsett")]
        [Description("Hovedområder som dekkes i kompetansemålsettet")]
        public List<HovedområdeIKompetansemålsett> HovedområderIKontekstAvKompetansemålsett { get; set; }

        [DataMember(Order = 1, Name = "kompetansemaal")]
        [Description("Oversikt over kompetansemål for aktuelle hovedområde i kompetansemålsett")]
   
        public List<Kompetansemål> Kompetansemål { get; set; }

        [DataMember(Order = 1, Name = "etter-fag")]
        [Description("Tilknyttede opplæringsfag")]
 
        public List<Referanse> EtterFag { get; set; }

        [DataMember(Order = 2, Name = "etter-aarstrinn")]
        [Description("Etter hvilke årstrinn kompetansemålsettet skal være oppfylt")]
        public List<Referanse> EtterÅrstrinn { get; set; }
    }
}