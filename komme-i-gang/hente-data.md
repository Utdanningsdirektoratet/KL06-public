# Hente data

KL06 er strukturert slik at man kan hente ned en liste av minimumsinformasjon over de ulike [elementene](../oversikt_over_api.md#typer) i Grep.

Formatet på disse listene er *beta-data.udir.no/kl06/{element-type}* f.eks. [http://beta-data.udir.no/kl06/laereplaner](http://beta-data.udir.no/kl06/laereplaner).

Om du benytter SOAP-formatet så tilsvarer disse listene operasjonene Finn*{element-type}*, f eks [FinnPlaner](http://beta-data.udir.no/kl06/soap#FinnPlaner).
Hvert av resultatene i minimumsinformasjonen har et felt som heter url-beta-data. Denne peker til endepunktet for det aktuelle elementet. Formatet på dette endepunktet er alltid *beta-data.udir.no/kl06/{kode}*, f eks [http://beta-data.udir.no/kl06/MAT1-04](http://beta-data.udir.no/kl06/MAT1-04). Referanser inne i elementet mot andre elementer vil også ha tilsvarende *url-data*-felt. Unntaket er feltene *status* og *spraak* hvor verdien peker direkte mot endepunktet for den aktuelle verdien.