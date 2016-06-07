# Komme i gang

KL06 kan nås fra http://data.udir.no/kl06 og er tilgjengelig som et [REST](https://en.wikipedia.org/wiki/Representational_state_transfer)-api, et [SOAP](https://en.wikipedia.org/wiki/SOAP)-api og et [SPARQL](https://en.wikipedia.org/wiki/SPARQL)-endepunkt.

KL06s REST-grensesnitt er løselig basert på REST-arkitekturen, og kan kanskje mer korrekt beskrives som et HTTP-api.

Hvilket endepunkt du velger å benytte avhenger av hva du er ute etter. REST-grensesnittet er enkelt å ta i bruk, kan testes i en nettleser og er det anbefalte å benytte om du ikke er avhengig av et wsdl-skjema. Om du vil bli kjent med KL06 så anbefaler vi at du starter der. Datastrukturen for REST og SOAP er identisk, så det er relativt lett å bytte mellom disse to formatene.

## Hente data

KL06 er strukturert slik at man kan hente ned en liste av minimumsinformasjon over de ulike [elementene](/oversikt_over_api.md#typer) i Grep.

Formatet på disse listene er [http://data.udir.no/kl06/*{element-type}*]() f eks http://data.udir.no/kl06/laereplaner

Om du benytter SOAP-formatet så tilsvarer disse listene operasjonene Finn*{element-type}*, f eks [FinnPlaner](http://data.udir.no/kl06/soap#FinnPlaner).

Hvert av resultatene i minimumsinformasjonen har et felt som heter url-data. Denne peker til endepunktet for det aktuelle elementet. Formatet på dette endepunktet er alltid [http://data.udir.no/kl06/*{kode}*](), f eks http://data.udir.no/kl06/MAT1-04. Referanser inne i elementet mot andre elementer vil også ha tilsvarende *url-data*-felt. Unntaket er feltene *status* og *spraak* hvor verdien peker direkte mot endepunktet for den aktuelle verdien.

## Eksempler

Se [Eksempel](./eksempler.md)-kapittelet for demonstrasjoner av ulike måter å benytte kl06 på












