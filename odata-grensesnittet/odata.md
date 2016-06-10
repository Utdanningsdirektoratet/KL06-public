# OData-grensesnittet {#odata-grensesnittet}

Grep tilbyr et enkelt OData-grensesnitt for å søke etter elementer. Dette tilbys som et alternativ til det SOAP-baserte søket, i de tilfellene hvor det søket er for begrenset, eller der hvor man ikke vil benytte SOAP. OData-grensesnittet forholder seg til spesifikasjonene funnet på [http://www.odata.org/](http://www.odata.org/).

Grunn-URL til OData-grensesnittet er [http://data.udir.no/kl06/odata/](http://data.udir.no/kl06/odata/).


## OData og læreplaner {#odata-og-l-replaner}

For å spørre etter læreplaner, oppgir du URLen [http://data.udir.no/kl06/odata/Læreplan](http://data.udir.no/kl06/odata/Læreplan)

Figur 3: Læreplaner levert som RSS

Figur 4: Læreplan levert som JSON

På læreplan har vi følgende felt å jobbe med:

| **Felt** | **Beskrivelse** | **Eksempel** |
| --- | --- | --- |
| Tittel | Læreplanens tittel på fastsatt språk | [http://data.udir.no/kl06/odata/Læreplan?$filter=endswith(Tittel,'engelsk')](http://data.udir.no/kl06/odata/Læreplan?$filter=endswith%28Tittel,'engelsk'%29) (Returnerer alle læreplaner hvis tittel slutter med “_engelsk”)_ |
| Kode | Læreplanens kode | [	http://data.udir.no/kl06/odata/Læreplan?$filter=(Kode eq 'SFS2-01')](http://data.udir.no/kl06/odata/Læreplan?$filter=%28Kode eq 'SFS2-01'%29) |
| Psi | Læreplanens identifikator (eller PSI i Grep) | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi eq 'uuid:3e9bd273-f1cd-4631-854e-1229e384938c')](http://data.udir.no/kl06/odata/Læreplan?$filter=%28Psi eq 'uuid:3e9bd273-f1cd-4631-854e-1229e384938c'%29) |
| UrlData | Url til detaljert informasjon om læreplanen for maskinell behandling | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi eq 'uuid:3e9bd273-f1cd-4631-854e-1229e384938c')&$select=UrlData&$format=json](http://data.udir.no/kl06/odata/Læreplan?$filter=%28Psi eq 'uuid:3e9bd273-f1cd-4631-854e-1229e384938c'%29&$select=UrlData&$format=json) |
|  SistEndret | Når læreplanen sist ble oppdatert | [http://data.udir.no/kl06/odata/Læreplan?$filter=(SistEndret gt datetime'2011-01-01')](http://data.udir.no/kl06/odata/Læreplan?$filter=%28SistEndret gt datetime'2011-01-01'%29) |
| Status | Status til læreplanen | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Status eq 'http://psi.udir.no/ontologi/status/utgaatt')](http://data.udir.no/kl06/odata/Læreplan?$filter=%28Status eq 'http://psi.udir.no/ontologi/status/utgaatt'%29) |

## OData og programområder {#odata-og-programomr-der}

For å spørre etter programområder, oppgir du URL’en [http://data.udir.no/kl06/odata/Programområde](http://data.udir.no/kl06/odata/Programområde)

Filtreringsmulighetene er de samme som for fagkoder

## OData og utdanningsprogram {#odata-og-utdanningsprogram}

For å spørre etter utdanningsprogram, oppgir du URL’en http://data.udir.no/kl06/odata/Utdanningsprogram

Filtreringsmulighetene er de samme som for fagkoder

## OData og merknader {#odata-og-merknader}

For å spørre etter merknader, oppgir du URL’en http://data.udir.no/kl06/odata/Merknad

Filtreringsmulighetene er de samme som for fagkoder

## OData og merkelapper {#odata-og-merkelapper}

For å spørre etter merkelapper, oppgir du URL’en http://data.udir.no/kl06/odata/Merkelapp

Filtreringsmulighetene er de samme som for fagkoder

## OData og kompetansemål {#odata-og-kompetansem-l}

For å spørre etter kompetansemål, oppgir du URL’en http://data.udir.no/kl06/odata/Kompetansemål

Filtreringsmulighetene er de samme som for fagkoder

## OData og fagkategori {#odata-og-fagkategori}

For å spørre etter fagområde, oppgir du URL’en http://data.udir.no/kl06/odata/Fagkategori

Filtreringsmulighetene er de samme som for fagkoder

## OData og fagområde {#odata-og-fagomr-de}

For å spørre etter fagområde, oppgir du URL’en http://data.udir.no/kl06/odata/Fagområde

Filtreringsmulighetene er de samme som for fagkoder

## OData og årstrinn {#odata-og-rstrinn}

For å spørre etter fagområde, oppgir du URL’en http://data.udir.no/kl06/odata/Årstrinn

Filtreringsmulighetene er de samme som for fagkoder, med unntak av kode.