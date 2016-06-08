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

- Status har endret format til [*http://data.udir.no/kl06/statuskode*](http://data.udir.no/kl06/statuskode), feks [http://data.udir.no/kl06/status_publisert](http://data.udir.no/kl06/status_publisert). Dette er nå en peker på status-elementet, og man kan hente mer informasjon om status (oversettelser etc)
- url-psi er fjernet
- uri er lagt til som en nøkkel for elementer og referanser. Uri peker til ontologien (TODO - er dette riktig? Are?) for elementet
- grep-type er lagt til som nøkkel på typen til elementet eller referansene. Dette feltet er en oppslagbar uri til ontologien for typen.
