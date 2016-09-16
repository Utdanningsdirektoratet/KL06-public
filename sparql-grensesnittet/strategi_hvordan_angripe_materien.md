# Strategi: Hvordan angripe materien?
I dette avsnittet vil vi gi noen tips til hvordan du kan skaffe deg oversikt over hvordan du kan ta i bruk dataene via SPARQL-spørringer. 
Vi anbefaler følgende strategi:

1. Skaff deg oversikt med "utforskende SPARQL-spørringer"
2. Bruke det hu har lært i pkt. 1 til å grave dypere (og bruke dem videre til programmering)


## 1: Skaff deg oversikt med "utforskende SPARQL-spørringer"
I dette punktet vil vi vise hvordan du kan skaffe deg oversikt over
1. hvilke typer som finnes i datagrunnlaget
2. hvilke egenskaper som finnes


### Hvilke typer finnes i datagrunnlaget?
Kjør følgende spørring i SPARQL-grensesnittet i Grep (kopier spørringen nedenfor og lim inn i "spørre-feltet" til [endepunktet](http://data.udir.no/kl06/sparql)).

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://test-psi.udir.no/ontologi/kl06/>
SELECT DISTINCT ?type
WHERE {
?s rdf:grep-type ?type 
}
{%endace%}