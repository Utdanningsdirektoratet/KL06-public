# Oppbygging av "Fastsatt læreplantekst"

## Versjon 2016/04

Det er i dag lagt inn støtte for fire ulike læreplanvarianter
1.	Læreplan med hovedområder
2.	Læreplan med hovedområder i hierarki
3.	Læreplan med hovedområder under programfag
4.	Læreplan med programfag

### For læreplanvariant 1 og 2 ligger all tilhørende info i hovedomraade-kapittel i KL06

* Riktig overskrift ligger alltid inne basert på læreplanvariant
* Fritesktfeltet skal benyttes i de tilfellene dette er tilgjengelig
* Om det ikke finnes fritekst, skal kun overordnede hovedområder listes ut med tittel og beskrivelse

**Eksempler fra KL06:**
* Variant 1: http://beta-data.udir.no/kl06/mat1-04.pdf
* Variant 2: http://beta-data.udir.no/kl06/rle1-02.pdf
* Fritekst: http://beta-data.udir.no/kl06/NAT1-03.pdf

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

### For læreplanvariant 3 og 4 ligger all tilhørende info i programfag-kapittel i KL06

* Riktig overskrift ligger alltid inne basert på læreplanvariant
* I tilfeller der det kun ligger inne  programfag, uten underliggendeHovedområder, listes programfagene med tittel og beskrivelse
* I tilfeller der det finnes underliggendeHovedområder skal disse listes ut under aktuelt programfag

**Eksempler fra KL06:**
* Variant 3: http://beta-data.udir.no/kl06/pos1-02.pdf
* Variant 4: http://beta-data.udir.no/kl06/bat1-01.pdf

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

## Versjon 2013/11

Det er i denne versjonen lagt inn støtte for tre ulike læreplanvarianter
1.	Læreplan med hovedområder
2.	Læreplan med programfag
3.	Læreplan med hovedområder under programfag

### For å dekke alle læreplanvarianter må en hente info fra hovedomraade-overskrift, hovedomraader, hovedomraade-fritekst og kompetansemaalsett i KL06

* Riktig overskrift ligger alltid under hovedomraade-overskrift basert på læreplanvariant
* HovedområdeFritekst skal benyttes i de tilfellene dette er tilgjengelig
* Om det ikke finnes fritekst
 * Hovedområder listes ut med tittel og beskrivelse for variant 1
 * For variant 2 ligger programfagene inne som hovedområder. Det vil si at denne varianten håndteres tilsvarende variant 1. (Men innhold i overskrit er forskjellig)
 * SorterHovedråderUnderProgramfag angri variant 3
   * Her ligger underliggende hovedområder inne som hovedområder, mens programfag-tittel hentes fra kompetansemålsett-tittel.
   * Verdiene som hentes ut er:
    * Kompetansemålsett tittel
    * Tittel og beskrivelse for alle hovedområder under kompetansemålsettet



