## Versjonering {#versjonering}

Ved oppgraderinger og endringer i KL06-tjenestene så kan innholdet endre struktur og form. Disse vil tre i kraft umiddelbart etter oppgradering. Om man ønsker å være sikret på at innholdet forblir det samme inntil man får oppdatert sine egne systemer, kan man be om data under en spesifikk versjon. KL06 støtter per nå to versjoner – den nyeste og nest nyeste.

For å indikere at man ønsker data fra en spesifikk versjon, angir man et query-parameter _versjon_ med et spesifikt versjonsnummer.

Eksempelvis kan man spesifisere [http://beta-data.udir.no/kl06/laereplaner?versjon=http://psi.udir.no/kl06/2013/11](http://beta-data.udir.no/kl06/laereplaner?versjon=http://psi.udir.no/kl06/2013/11) for å være sikker på at man henter ut data med den strukturen som er/var aktuell for den versjonen. Dette parameteret fungerer på alle kall.