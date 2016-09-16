# RDF/SPARQL-grensesnitt og ontologi {#sparql-grensesnitt og ontologi}
Grep tilbyr også et RDF/SPARQL-grensesnitt som består av følgende komponenter:
* **Ontologi/maskinlesbar datamodell:** http://psi-udir.no/ontologi/kl06/
* * **Oppslag på type:** http://psi.udir.no/ontologi/kl06/[navn_på_type],
eksempel:
http://psi.udir.no/ontologi/kl06/laereplan 
eller: http://psi.udir.no/ontologi/kl06#laereplan
Denne inneholder definisjon av typer og egenskaper, samt modell-referanser
* * **Ontologien som nedlastbar owl-fil til maskinell behandling:** http://psi.udir.no/Ontologi/kl06.owl
* **Oppslag på PSI-adresser for data-elementer:** (http://psi.udir.no/kl06/[navn_på_element], eksempel:
http://psi.udir.no/kl06/NOR1-05)
* **SPARQL-endepunkt:**
http://data.udir.no/kl06/sparql

Disse komponentene er nærmere beskrevet nedenfor, men først noen ord om hvordan disse er tilknyttet de øvrige grensesnittene for Grep.

Ved for eksempel å lese .json-representasjonen av 
["Læreplan i Norsk", NOR1-05](http://data.udir.no/kl06/NOR1-05), kjenner vi igjen URLene som nevnes i oversiktene over. Se illustransjonen nedenfor:

![](illustrasjon_nor1-05_json.png)
*Ontologi og URI-oppslag/PSI-adresser i kl06 kan nå brukes til å skaffe seg oversikt (for mennesker) eller brukes som API (for maskiner)*






## URL-syntaks for ontologien og psi-oppslag
Siden det meste av kodeverket til Grep er URL-basert, kan det være nyttig å kjenne til hvordan vi har lagt opp syntaksen for disse.
###URL-syntaks for ontologien:
Vi har valgt å legge ontologien for Grep (kl06) på følgende URL, og med følgende syntaks:
http://psi-udir.no/ontologi/kl06/#[en_gitt_kode_for_enten_type_eller_egenskap]
Forklaring på hvert ledd:
- **psi**: (published subject identifier) for å skille det fra data-elementer (som ligger under data.udir.no) og på den måten markere at det har med modellen å gjøre
- **.udir.no/ontologi/**: Teoretisk kan udir.no ha sin egen, overordnede ontologi i fremtiden, men her snakker vi om 
- **kl06/**: som er Greps ontologi (i teorien kan andre prosjekter i Udir-domenet opprette sine egne ontologier etter formen http://psi.udir.no/ontologi/[navn_på_spesifikk_ontologi_i_udir-domenet]

###URL-syntaks for PSI-oppslag:
Syntaksen over, er for typer og egenskaper i datamodellen, mens syntaksen for det vi kaller PSI-oppslag, fjerner vi ontologi-leddet for å uttrykke at vi her ser på et data-element.
URL-syntaksen blir da etter formen http://psi.udir.no/kl06/[kode], altså likt som for data-oppslag (http://data.udir.no/kl06/[kode]), med den forskjellen at "data" er erstattet med "psi". Disse URLene brukes typisk som publiserte, unike, identifikatorer - men ved å slå dem opp, finner du også referanse til både data-oppslag ("hva har jeg") og til ontologien ("hvilken type er jeg"). På den måten blir PSI-oppslag broen mellom datamodellen og selve dataene i Grep.

## SPARQL-endepunkt
...Anvendelse av ontologi- og psi-referanser kan gjøres via SPARQL-spørringer

...Vi tanker Grep-data til en egen database (Virtuoso) for RDF og SPARQL-bruk.



...Noen ord om bruken av psi-adresser VS data-adresser i SPARQL-spørringer
