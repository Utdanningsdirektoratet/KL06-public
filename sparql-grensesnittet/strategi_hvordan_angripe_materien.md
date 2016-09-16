# Strategi: Hvordan angripe materien
I dette avsnittet vil vi gi noen tips til hvordan du kan skaffe deg oversikt over hvordan du kan ta i bruk dataene via SPARQL-spørringer. 
Vi anbefaler følgende strategi:

1. Skaff deg oversikt med "utforskende SPARQL-spørringer"
2. Bruke det du har lært i pkt. 1 til å grave dypere (og bruke dem videre til programmering)


## 1: Skaff deg oversikt med "utforskende SPARQL-spørringer"
I dette punktet vil vi vise hvordan du kan skaffe deg oversikt over
1. hvilke typer som finnes i datagrunnlaget
2. hvilke egenskaper som finnes


### Hvilke typer finnes i datagrunnlaget?
Kjør følgende spørring i SPARQL-grensesnittet i Grep (kopier spørringen nedenfor og lim inn i "spørre-feltet" til [endepunktet]

(http://data.udir.no/kl06/sparql)).

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
SELECT DISTINCT ?type
WHERE {
?s ontologi:grep-type ?type 
}
{%endace%}

*Legg merke til linje 1:* ```PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>```*. Denne er med, for at vi skal slippe å skrive hele URLen i f.eks linje 4, men heller skrive* ```ontologi:grep-type```*. Med andre ord - på linje 4 står det egentlig: *```?s <http://psi.udir.no/ontologi/kl06/grep-type> ?type```

Denne spørringen gir følgende resultat (ved valg av HTML som resultat-format):

| **type** |
| -- |
| http://psi.udir.no/ontologi/kl06/fagkode |
| http://psi.udir.no/ontologi/kl06/status |
| http://psi.udir.no/ontologi/kl06/laereplan |
| http://psi.udir.no/ontologi/kl06/fagkategori |
| http://psi.udir.no/ontologi/kl06/fagomraade |
| http://psi.udir.no/ontologi/kl06/opplaeringsfag |
| http://psi.udir.no/ontologi/kl06/utdanningsprogram |
| http://psi.udir.no/ontologi/kl06/programomraade |
| http://psi.udir.no/ontologi/kl06/merknad |
| http://psi.udir.no/ontologi/kl06/opplaeringsnivaa |
| http://psi.udir.no/ontologi/kl06/aarstrinn |
| http://psi.udir.no/ontologi/kl06/spraak |
| http://psi.udir.no/ontologi/kl06/fagtype |
| http://psi.udir.no/ontologi/kl06/merkelapp |
| http://psi.udir.no/ontologi/kl06/kompetansemaal |
| http://psi.udir.no/ontologi/kl06/hovedomraade |
| http://psi.udir.no/ontologi/kl06/kompetansemaalsett |
| http://psi.udir.no/ontologi/kl06/programfag |

