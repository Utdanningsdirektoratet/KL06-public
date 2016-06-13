# REST-grensesnittet {#rest-grensesnittet}

I tabellen nedenfor har vi listet opp hvilke URLer du kan bruke for å hente ut de ulike elementene. REST-grensesnittet støtter en rekke ulike formater. Om du vil bruke et annet format enn standardformatet (JSON), oppgir du dette ved å legge på {.format} på slutten av URLen. Eksempelvis for å liste ut alle fag i xml-format, oppgir du [http://data.udir.no/kl06/fagkoder.xml](http://data.udir.no/kl06/fagkoder.xml).

## Versjonering {#versjonering}

Ved oppgraderinger og endringer i KL06-tjenestene så kan innholdet endre struktur og form. Disse vil tre i kraft umiddelbart etter oppgradering. Om man ønsker å være sikret på at innholdet forblir det samme inntil man får oppdatert sine egne systemer, kan man be om data under en spesifikk versjon. KL06 støtter per nå to versjoner – den nyeste og nest nyeste.

For å indikere at man ønsker data fra en spesifikk versjon, angir man et query-parameter _versjon_ med et spesifikt versjonsnummer.

Eksempelvis kan man spesifisere [http://data.udir.no/kl06/laereplaner?versjon=http://psi.udir.no/kl06/2013/11](http://data.udir.no/kl06/laereplaner?versjon=http://psi.udir.no/kl06/2013/11) for å være sikker på at man henter ut data med den strukturen som er/var aktuell for den versjonen. Dette parameteret fungerer på alle kall.

## Språkvalg i rest {#spr-kvalg-i-rest}

Det er mulig å velge ut tekster på et bestemt språk ved å legge inn {?lang=xxx}. Der språket angis i henhold til ISO 639-2 standarden. http://data.udir.no/kl06/MAT1-04?lang=nno vil gi deg den gitte læreplanen med kun nynorske tekster. Dersom det ikke finnes oversettelser på dette språket vil tekstfeltene vises som tom liste.

Dersom en ikke angir noe språk vil en få ut alle tilgjengelige oversettelser for angitt element. Eks. http://data.udir.no/kl06/MAT1-03. Dersom en vil hente ut elementet på «hovedspråk», som i hovedsak variere mellom nynorsk og bokmål, setter en lang=default. Eks. [http://data.udir.no/kl06/MAT1-03?lang=default](http://data.udir.no/kl06/MAT1-03?lang=default) vil vise MAT1-03 på nynorsk.

| **Url** | **Beskrivelse** | **Støttede formater** | **Eksempel** |
| --- | --- | --- | --- |
| [http://data.udir.no/kl06/fagkoder{.format}{?lang=XXX}](http://data.udir.no/kl06/fagkoder%7b.format%7d%7b?lang=XXX%7d) | Henter ut alle fag i Grep | RSS/Atom (.atom) | [http://data.udir.no/kl06/fagkoder](http://data.udir.no/kl06/fagkoder) (gir tilbake alle fagkoder i standardformat) |
| http://data.udir.no/kl06/laereplaner{.format}{?lang=XXX} | Henter ut alle læreplaner i Grep | RSS/Atom (.atom) | [http://data.udir.no/kl06/laereplaner](http://data.udir.no/kl06/laereplaner) (gir tilbake alle læreplaner i standardformat) |
| http://data.udir.no/kl06/utdanningsprogram{.format}{?lang=XXX} | Henter ut alle utdanningsprogram i Grep | RSS/Atom (.atom) | http:/[/data.udir.no/kl06/utdanningsprogram](http://data.udir.no/kl06/utdanningsprogram) (gir tilbake alle utdanningsprogram i standardformat) |
| http://data.udir.no/kl06/programomraader{.format}{?lang=XXX} | Henter ut alle programområder i Grep | RSS/Atom (.atom) | [http://data.udir.no/kl06/programomraader](http://data.udir.no/kl06/programomraader) (gir tilbake alle programområder i standardformat) |
| http://data.udir.no/kl06/merknader{.format}{?lang=XXX} | Henter ut alle merknader i Grep | RSS/Atom (.atom) | [http://data.udir.no/kl06/merknader](http://data.udir.no/kl06/merknader) (gir tilbake alle merknader i standardformat) |
| http://data.udir.no/kl06/merkelapper{.format}{?lang=XXX} | Henter ut alle merkelapper i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/merkelapper (gir tilbake alle merkelapper i standardformat) |
| http://data.udir.no/kl06/fagomraader{.format}{?lang=XXX} | Henter ut alle fagområder i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/fagomraader (gir tilbake alle fagområder i standardformat) |
| http://data.udir.no/kl06/fagkategorier{.format} | Henter ut alle fagkategorier i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/fagkategorier (gir tilbake alle fagkategorier i standardformat) |
| http://data.udir.no/kl06/kompetansemaal{.format}{?lang=XXX} | Henter ut alle kompetansemål i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/kompetansemaal (gir tilbake alle kompetansemål i standardformat) |
| http://data.udir.no/kl06/opplaeringsfag{.format}{?lang=XXX} | Henter ut alle opplæringsfag i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/opplaeringsfag (gir tilbake alle opplæringsfag i standardformat) |
| http://data.udir.no/kl06/aarstrinn{.format}{?lang=XXX} | Henter ut alle årstrinn i Grep | RSS/Atom (.atom) | http://data.udir.no/kl06/aarstrinn (gir tilbake alle årstrinn i standardformat) |
| http://data.udir.no/kl06/{kode}{.format}{?lang=XXX} | Henter ut et element i Grep. Foreløpig kan disse elementene hentes ut: | XML (.xml) | [http://data.udir.no/kl06/IDR1-01](http://data.udir.no/kl06/IDR1-01) |