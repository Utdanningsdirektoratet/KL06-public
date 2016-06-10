## Språkvalg i soap {#spr-kvalg-i-soap}

For alle metoder er det mulig å legge inn språkvalg. Språket angis i henhold til ISO 639-2\. Dersom det ikke finnes oversettelser på det valgte språket, vil tekstfeltene vises som tom verdi og i tillegg vil default verdien komme med. Dersom en ikke angir noe språk, vil en få ut alle tilgjengelige oversettelser for angitt element. Og om en vil hente ut elementet på «hovedspråk», som i hovedsak varierer mellom nynorsk og bokmål, settes valgt språk lik «default».

*Eksempel 1: Uthenting av MAT1-03 på engelsk.*

```xml
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:ns="http://psi.udir.no/kl06/2013/11">
  <soapenv:Header/>
  <soapenv:Body>
    <ns:HentPlanFraKode>
      <!--Optional:-->
      <ns:kode>
        <!--Optional:-->
        <ns:Kode>mat1-03</ns:Kode>
        <!--Optional:-->
        <ns:valgt-spraak>nob</ns:valgt-spraak>
      </ns:kode>
    </ns:HentPlanFraKode>
  </soapenv:Body>
</soapenv:Envelope>
```
*Eksempel 2: Uthenting av MAT1-03 på hovedspråk.*
```xml
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:ns="http://psi.udir.no/kl06/2013/11">
  <soapenv:Header/>
  <soapenv:Body>
    <ns:HentPlanFraKode>
      <!--Optional:-->
      <ns:kode>
        <!--Optional:-->
        <ns:Kode>mat1-03</ns:Kode>
        <!--Optional:-->
        <ns:valgt-spraak>default</ns:valgt-spraak>
      </ns:kode>
    </ns:HentPlanFraKode>
  </soapenv:Body>
</soapenv:Envelope>
```