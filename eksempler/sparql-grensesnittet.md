# SPARQL-grensesnittet

Her er en samling praktiske eksempler på SPARQL-spørringer mot SPARQL-endepunktet  http://data.udir.no/kl06/sparql.

I eksemplene nedenfor har vi valgt å legge til følgende prefixer, selv om ikke alle blir brukt i hver spørring:

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
{%endace%}

### List alle læreplaner med egne kolonner for default-språk, bokmål og nynorsk

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT REDUCED ?uri ?default ?bokmaal ?nynorsk ?kode 
WHERE {
?uri rdf:type ontologi:laereplan ;
ontologi:tittel ?default ;
ontologi:kode ?kode ;
ontologi:status data:status_publisert
FILTER (lang(?default) = "") .
OPTIONAL {
?uri ontologi:tittel ?nynorsk
FILTER (lang(?nynorsk) = "nno") .
}
OPTIONAL {
?uri ontologi:tittel ?bokmaal
FILTER (lang(?bokmaal) = "nob") .
}
} ORDER BY str(?kode)
{%endace%}

Her vil du se at det i noen få tilfeller er snakk om både bokmål og nynorsk (gjelder altså noen få læreplaner som er oversatt fra nynorsk til bokmål), men hovedregelen er at de kun foreligger i den ene målformen. Derfor er det tryggest å spørre etter hovedspråket med ```FILTER (lang(?tittel) = "")```

Vær også oppmerksom på at typen laereplan har egenskapen http://psi.udir.no/ontologi/kl06/har-fastsettelsesinformasjon-fastsatt-spraak som angir det aktuelle språket (f.eks. http://psi.udir.no/kl06/nno)

Videre vil egenskapen (fortsatt for laereplan) http://psi.udir.no/ontologi/kl06/har-tilgjengelige-spraak, liste de språkene som er tilgjengelig for den aktuelle læreplanen (etter samme form som over).


### Finn læreplan fra fagområde (i dette eksempelet FOMR404). 
Her må vi gå via kompetansemålsett (KMS):

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>

SELECT ?uri ?tittel ?kode WHERE {
{
SELECT DISTINCT ?lp WHERE {
?psi ontologi:url-data data:FOMR404 ;
ontologi-rev:har-fagomraade-referanser ?fomr .

?fomr ontologi:status data:status_publisert ;
ontologi-rev:har-etter-fag ?kms .

?kms ontologi-rev:har-kompetansemaalsett ?lp
}
}
?lp ontologi:status data:status_publisert ;
ontologi:url-data ?uri ;
ontologi:tittel ?tittel ;
ontologi:kode ?kode
FILTER (lang(?tittel) = "")
} ORDER BY str(?tittel)
{%endace%}

Hvis du ønsker å få ut en liste over alle fagområder kan du gjøre det ved å erstatte "ontologi:laereplan" med "ontologi:fagomraade" i spørringen "Hent alle læreplaner" øverst på denne siden.

### Kompetansemålsett fra læreplan
{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT ?UrlData ?uri ?navn WHERE {
?psi ontologi:url-data <http://data.udir.no/kl06/NOR1-05> ;
ontologi:har-kompetansemaalsett ?kms .
?kms ontologi:url-data ?UrlData ;
ontologi:uri ?uri ;
ontologi:tittel ?navn
FILTER (lang(?navn) = "") .
} ORDER BY ?UrlData
{%endace%}

### Opplæringsfag fra kompetansemålsett
{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT ?opplaeringsfag ?navn WHERE {
?node ontologi:url-data data:KMS943 ;
ontologi:har-etter-fag ?psiOpplFag .
?psiOpplFag ontologi:status data:status_publisert ;
ontologi:url-data ?opplaeringsfag ;
ontologi:tittel ?navn
FILTER (lang(?navn) = '') .
} ORDER BY ?opplaeringsfag
{%endace%}

### Kompetansemålene i et kompetansemålsett
{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT ?kompetansemaal ?name ?kode WHERE {
?psi ontologi:url-data data:KMS943 ;
ontologi:har-kompetansemaal ?harKmaal .
?harKmaal ontologi:status data:status_publisert ;
ontologi:url-data ?kompetansemaal ;
ontologi:kode ?kode ;
ontologi:tittel ?name
FILTER (lang(?name) = '') .
} ORDER BY STR(?name)
{%endace%}

### Hovedområder fra læreplan
{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT ?hovedomraade ?navn WHERE {
?psi ontologi:url-data data:NOR1-05 ;
ontologi:har-hovedomraade ?ho .
?ho ontologi:url-data ?hovedomraade ;
ontologi:tittel ?navn
FILTER (lang(?navn) = '') .
}
{%endace%}

### Hente alle trinn
{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX ontologi-rev: <http://psi.udir.no/ontologi/kl06/reversert/>
PREFIX data: <http://data.udir.no/kl06/>
SELECT ?trinn ?navn WHERE {
?trinn rdf:type ontologi:aarstrinn ;
ontologi:kode ?kode ;
ontologi:tittel ?navn
FILTER (lang(?navn) = '')
} ORDER BY str(?kode)
{%endace%}
