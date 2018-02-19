# Oppbygging av hovedområde- og programfag-kapitlene slik de er fastsatt
Læreplanene blir fastsatt som papirdokumenter uten veldig streng mal for oppsett. Følgelig finnes det mange varianter av hvordan disse dokumentene er strukturert. I Grep-databasen er det laget felter og strukturer som skal fange disse ulikhetene og gjøre det mulig å behandle innholdselementene likt på tvers av læreplanene, samtidig som det skal kunne være mulig å gjenskape teksten i hver enkelt læreplan slik som den ble fastsatt. Noe av det mest komplekse er hovedområde- og beskrivelse av programfag-kapitlene, som vi fra 2016/04 kan gjenskape uten å måtte ty til "fritekstfelt" (preformaterte kapitler). Vi vil her beskrive hvordan du kan gjenskape disse kapitlene slik de ble fastsatt.

## Fra versjon 2016/04

Det er i dag støtte for fire ulike varianter
1.	Læreplan med hovedområder
2.	Læreplan med hovedområder i hierarki
3.	Læreplan med hovedområder under programfag
4.	Læreplan med programfag

### For læreplanvariant 1 og 2 ligger all tilhørende info i *hovedomraade-kapittel* i KL06

* Riktig overskrift ligger alltid inne basert på læreplanvariant
* Fritekstfeltet skal benyttes i de tilfellene dette er tilgjengelig
* Om det ikke finnes fritekst, skal kun overordnede hovedområder listes ut med tittel og beskrivelse

**Eksempler fra KL06:**
* Variant 1: http://data.udir.no/kl06/MAT1-04.pdf
* Variant 2: http://data.udir.no/kl06/RLE1-02.pdf
* Fritekst: http://data.udir.no/kl06/NAT1-03.pdf

**Eksempelkode:**

{%ace edit=false, check=false%}

    @if (Model.HovedområdeKapittel != null && (string.IsNullOrEmpty(Model.HovedområdeKapittel.HovedområdeFritekst) == false || Model.HovedområdeKapittel.Hovedområder.Any() == true))
        {
            <h2>
                @if (string.IsNullOrEmpty(Model.HovedområdeKapittel.HovedområdeOverskrift))
                {
                    @Html.Raw(oversettelsermangler)
                }
                else
                {
                    @Html.Raw(Model.HovedområdeKapittel.HovedområdeOverskrift)
                }
            </h2>

            if (string.IsNullOrEmpty(Model.HovedområdeKapittel.HovedområdeFritekst) == false)
            {
                 @Html.Raw(Model.HovedområdeKapittel.HovedområdeFritekst)
            }
            else {
                foreach (var hovedområde in Model.HovedområdeKapittel.Hovedområder)
                {
                    <h4>
                        @Html.Raw(hovedområde.Tittel)
                    </h4>

                    @Html.Raw(@hovedområde.Beskrivelse)
                }
            }
        }
{%endace%}

### For læreplanvariant 3 og 4 ligger all tilhørende info i *programfag-kapittel* i KL06

* Riktig overskrift ligger alltid inne basert på læreplanvariant
* I tilfeller der det kun ligger inne  programfag, uten underliggende hovedområder, listes programfagene med tittel og beskrivelse
* I tilfeller der det finnes underliggende hovedområder skal disse listes ut under aktuelt programfag

**Eksempler fra KL06:**
* Variant 3: http://data.udir.no/kl06/POS1-02.pdf
* Variant 4: http://data.udir.no/kl06/BAT1-01.pdf

**Eksempelkode som dekker begge variantene: **

{%ace edit=false, check=false%}
    
    @if (Model.ProgramfagKapittel != null && Model.ProgramfagKapittel.Programfag.Any() == true)
        {
            <h2>
                @if (string.IsNullOrEmpty(Model.ProgramfagKapittel.ProgramfagOverskrift))
                {
                    @Html.Raw(oversettelsermangler)
                }
                else
                {
                    @Html.Raw(Model.ProgramfagKapittel.ProgramfagOverskrift)
                }
            </h2>

            foreach (var programfag in Model.ProgramfagKapittel.Programfag)
            {
                <h3>
                    @Html.Raw(programfag.Tittel)
                </h3>

                    @Html.Raw(@programfag.Beskrivelse)

                foreach (var hovedområde in programfag.UnderliggendeHovedområder)
                {
                    <h4>
                        @Html.Raw(hovedområde.Tittel)
                    </h4>

                    @Html.Raw(@hovedområde.Beskrivelse)
                }
            }
        }
{%endace%}
