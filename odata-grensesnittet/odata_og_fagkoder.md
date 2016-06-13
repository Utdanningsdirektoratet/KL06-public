## OData og fagkoder {#odata-og-fagkoder}

For å spørre etter fagkoder, oppgir du URLen [http://data.udir.no/kl06/odata/Fagkode](http://data.udir.no/kl06/odata/Fagkode) (merk: OData-grensesnittet skiller mellom store og små bokstaver). OData leverer som default en RSS-feed, men du har også mulighet til spesifikt å få returnert JSON.

![Figur 1: Fagkoder som RSS-feed](./gitbook/images/figur1.PNG)
Figur 1: Fagkoder som RSS-feed

Figur 2: Fagkoder som JSON (merk bruk av ?$format=json i URL)

På fagkoder kan du bruke følgende felter til å filtrere resultater:

| **Felt** | **Beskrivelse** | **Eksempel** |
| --- | --- | --- |
| Tittel | Fagkodens tittel på default språk | [http://data.udir.no/kl06/odata/Fagkode?$filter=startswith(Tittel,'Tverrfaglig')](http://data.udir.no/kl06/odata/Fagkode?$filter=startswith%28Tittel,'Tverrfaglig'%29) (Returnerer alle fagkoder hvis tittel starter med “_Tverrfaglig”)_ |
| Kode | Fagkodens kode | [http://data.udir.no/kl06/odata/Fagkode?$filter=(Kode eq 'ENG0001')](http://data.udir.no/kl06/odata/Fagkode?$filter=%28Kode eq 'ENG0001'%29) |
| Psi | Fagkodens identifikator (eller PSI i Grep) | [http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')](http://data.udir.no/kl06/odata/Fagkode?$filter=%28Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424'%29) |
| UrlData | Url til detaljert informasjon om fagkoden for maskinell behandling | [http://data.udir.no/kl06/odata/Fagkode?$filter=(Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424')&$select=UrlData&$format=json](http://data.udir.no/kl06/odata/Fagkode?$filter=%28Psi eq 'uuid:59d5b28c-963b-40d4-bf41-eff7b333b424'%29&$select=UrlData&$format=json) |
| SistEndret | Når fagkoden sist ble oppdatert | [http://data.udir.no/kl06/odata/Fagkode?$filter=(SistEndret gt datetime'2011-01-01')](http://data.udir.no/kl06/odata/Fagkode?$filter=%28SistEndret gt datetime'2011-01-01'%29) |
| Status | Status til fagkoden | [http://data.udir.no/kl06/odata/Fagkode?$filter=(Status eq 'http://psi.udir.no/ontologi/status/utgaatt')](http://data.udir.no/kl06/odata/Fagkode?$filter=%28Status eq 'http://psi.udir.no/ontologi/status/utgaatt'%29) |
