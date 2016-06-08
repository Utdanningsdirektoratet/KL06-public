# OData-grensesnittet {#odata-grensesnittet}

Grep tilbyr et enkelt OData-grensesnitt for å søke etter elementer. Dette tilbys som et alternativ til det SOAP-baserte søket, i de tilfellene hvor det søket er for begrenset, eller der hvor man ikke vil benytte SOAP. OData-grensesnittet forholder seg til spesifikasjonene funnet på [http://www.odata.org/](http://www.odata.org/).

Grunn-URL til OData-grensesnittet er [http://data.udir.no/kl06/odata](http://data.udir.no/kl06/odata)/.

## OData og fagkoder {#odata-og-fagkoder}

For å spørre etter fagkoder, oppgir du URLen [http://data.udir.no/kl06/odata/Fagkode](http://data.udir.no/kl06/odata/Fagkode) (merk: OData-grensesnittet skiller mellom store og små bokstaver). OData leverer som default en RSS-feed, men du har også mulighet til spesifikt å få returnert JSON.

Figur 1: Fagkoder som RSS-feed

Figur 2: Fagkoder som JSON (merk bruk av ?$format=json i URL)

På fagkoder kan du bruke følgende felter til å filtrere resultater:

| **Felt** | **Beskrivelse** | **Eksempel** |
| --- | --- | --- |
| Tittel | Fagkodens tittel på default språk | [http://data.udir.no/kl06/odata/Fagkode?$filter=startswith(Tittel,'Tverrfaglig')](http://data.udir.no/kl06/odata/Fagkode?$filter=startswith%28Tittel,'Tverrfaglig'%29) (Returnerer alle fagkoder hvis tittel starter med “_Tverrfaglig”)_ |
| Kode | Fagkodens kode | 
[http://data.udir.no/kl06/odata/Fagkode?$filter=(Kode eq 'ENG0001')](http://data.udir.no/kl06/odata/Fagkode?$filter=%28Kode eq 'ENG0001'%29) |
| Psi | Fagkodens identifikator (eller PSI i Grep) | [http://data.udir.no/kl06/odata](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20')[/Fagkode?$filter=(Psi eq '](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20')[uuid:59d5b28c-963b-40d4-bf41-eff7b333b424](http://data.udir.no/odata/Fag?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424'))[')](http://data.udir.no/odata/Fag?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')) |
| UrlData | Url til detaljert informasjon om fagkoden for maskinell behandling | [http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlD](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlData&$format=json)[ata&$format=json](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlData&$format=json) |
| UrlPsi | Url til detaljert informasjon om fagkoden for brukere | [http://data.udir.no/kl06/odata](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlPsi&$format=json)[/Fagkode?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlPsi&$format=json](http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlPsi&$format=json) |
| SistEndret | Når fagkoden sist ble oppdatert | [http://data.udir.no/kl06/odata/Fagkode?$filter=(](http://data.udir.no/kl06/odata/Fagkode?$filter=(SistEndret%20gt%20datetime'2011-01-01'))[SistEndre](http://data.udir.no/kl06/odata/Fagkode?$filter=(SistEndret%20gt%20datetime'2011-01-01'))[t gt datetime'2011-01-01')](http://data.udir.no/kl06/odata/Fagkode?$filter=(SistEndret%20gt%20datetime'2011-01-01')) |
| Status | Status til fagkoden | [http://dat](http://data.udir.no/kl06/odata/Fagkode?$filter=(Status%20eq%20'http://psi.udir.no/ontologi/status/utgaatt'))[a.udir.no/kl06/odata/Fagkode?$filter=(Status eq](http://data.udir.no/kl06/odata/Fagkode?$filter=(Status%20eq%20'http://psi.udir.no/ontologi/status/utgaatt')) ['http://psi.udir.no/on](http://data.udir.no/kl06/odata/Fagkode?$filter=(Status%20eq%20'http://psi.udir.no/ontologi/status/utgaatt'))tologi/status/utgaatt') |

## OData og læreplaner {#odata-og-l-replaner}

For å spørre etter læreplaner, oppgir du URLen [http://data.udir.no/kl06/odata/Læreplan](http://data.udir.no/kl06/odata/Læreplan)

Figur 3: Læreplaner levert som RSS

Figur 4: Læreplan levert som JSON

På læreplan har vi følgende felt å jobbe med:

| **Felt** | **Beskrivelse** | **Eksempel** |
| --- | --- | --- |
| Tittel | Læreplanens tittel på fastsatt språk | [http://data.udir.no/kl06/odata/Læreplan?$filter=endswith(Tittel,'engelsk')](http://data.udir.no/kl06/odata/Læreplan?$filter=endswith(Tittel,'engelsk')) (Returnerer alle læreplaner hvis tittel slutter med “_engelsk”)_ |
| Kode | Læreplanens kode | [http://data.udir.no/odata/kl06/Læreplan?$filter=(Kode eq 'SFS2-01')](http://data.udir.no/odata/kl06/Læreplan?$filter=(Kode%20eq%20'SFS2-01')) |
| Psi | Læreplanens identifikator (eller PSI i Grep) | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi eq 'uuid:3e9bd273-f1cd-4631-854e-1229e384938c')](http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi%20eq%20'uuid:3e9bd273-f1cd-4631-854e-1229e384938c')) |
| UrlData | Url til detaljert informasjon om læreplanen for maskinell behandling | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=Ur](http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlData&$format=json)[lData&$format=json](http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlData&$format=json) |
| UrlPsi | Url til detaljert informasjon om læreplanen for brukere | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=Url](http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlPsi&$format=json)[Psi&$format=json](http://data.udir.no/kl06/odata/Læreplan?$filter=(Psi%20eq%20'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlPsi&$format=json) |
| SistEndret | Når læreplanen sist ble oppdatert | [http://data.udir.no/kl06/odata/Lærepla](http://data.udir.no/kl06/odata/Læreplan?$filter=(SistEndret%20gt%20datetime'2011-01-01'))[n?$filter=(SistEndret gt datetime'2011-01-01')](http://data.udir.no/kl06/odata/Læreplan?$filter=(SistEndret%20gt%20datetime'2011-01-01')) |
| Status | Status til læreplanen | [http://data.udir.no/kl06/odata/Læreplan?$filter=(Status eq 'http://psi.udir.no/ontologi/st](http://data.udir.no/kl06/odata/Læreplan?$filter=(Status%20eq%20'http://psi.udir.no/ontologi/status/utgaatt'))[atus/utgaatt')](http://data.udir.no/kl06/odata/Læreplan?$filter=(Status%20eq%20'http://psi.udir.no/ontologi/status/utgaatt')) |

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