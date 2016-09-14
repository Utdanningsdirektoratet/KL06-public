# Endringer 2016/04

## Generelt

Denne versjonen av KL06 inneholder en del omstruktureringer på læreplaner og noen endringer på felles elementer.


### Læreplan

- De ulike kapitlene i læreplanen har blitt gruppert sammen med de respektive overskriftene for kapittelet. Eksempelvis *formaal-overskrift* og *formaal* ligger nå som *overskrift* og *tekst* under *formaal-kapittel*
- Programfag har blitt introdusert som en egen entitet for felles programfag (tidligere versjoner har bakt disse inn i hovedområder). Programfag blir referert til fra kompetansemålsettet
- Hovedområder kan nå ha underliggende hovedområder.
- Kompetansemålsett har endret struktur til
  - Kompetansemålsettkapittel
    - Overskrift
    - Innledning
    - Kompetansemålsett
      - Etter Årstrinn
      - Hovedområder brukt i dette kompetansemålsettet, med eventuelle alternativ tittel og beskrivelse i kontekst av det aktuelle kompetansemålsett
      - Kompetansemål brukt av kompetansemålsettet. Kompetansemålet vil ha en peker *tilhoerer-hovedomraade* som viser til hvilket hovedområde den tilhører

### Generelt

- Status har endret format til *data.udir.no/kl06/{statuskode}*, feks [http://data.udir.no/kl06/status_publisert](http://data.udir.no/kl06/status_publisert). Dette er nå en peker på status-elementet, og man kan hente mer informasjon om status (oversettelser etc)
- Koding av språk for tekst har endret format til *data.udir.no/kl06/{ISO 639-2-kode}*, for eksempel http://data.udir.no/kl06/nob.
- url-psi er fjernet
- uri er lagt til som en nøkkel for elementer og referanser. Uri peker til ontologien for elementet
- grep-type er lagt til som nøkkel på typen til elementet eller referansene. Dette feltet er en oppslagbar uri til ontologien for typen.
- Det har kommet en del endringer i datagrunnlaget, beskrevet i [Appendix A](../appendix_a.html).

### Endringer i KL06 (v. 2016/04) 14. september
Grep-APIene er utvidet med funksjonalitet vi har forespeilet tidligere, hovedsakelig for å støtte opprettelsen av et nytt endpoint (RDF/SparQL).
-	Direkteoppslag på underelementer av læreplan: kompetansemålsett (KMS), hovedområde(HO) og programfag(PF). Disse elementene har nå url-data-lenker som kan slås opp.
-	PSI-server. Alle uri- og grep-type-felt har psi.udir.no-lenker, som nå kan slås opp for mer informasjon om element eller definisjon av type.
-	SparQL-endpoint. Brukere kan nå benytte vårt SparQL-endpoint på http://data.udir.no/kl06/sparql
- Ontologi for Grep (maskinlesbar datamodell), slik den er implementert for SparQL. Se http://psi.udir.no/ontologi/kl06 
