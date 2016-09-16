# Strategi: Hvordan angripe materien
I dette avsnittet vil vi gi noen tips til hvordan du kan skaffe deg oversikt over hvordan du kan ta i bruk dataene via SPARQL-spørringer. 
Vi anbefaler følgende strategi:

1. Skaff deg oversikt med "utforskende SPARQL-spørringer"
2. Bruke det du har lært i pkt. 1 til å grave dypere (og bruke det videre til programmering)


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

*Legg merke til linje 1:* ```PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>```*. Denne er med, for at vi skal slippe å skrive hele URLen i f.eks linje 4, men heller skrive* ```ontologi:grep-type```*. Med andre ord - på linje 4 står det egentlig: *```?s <http://psi.udir.no/ontologi/kl06/grep-type> ?type```.
*Oversatt til menneskespråk: "Gi meg subjekt (kalt "?s") der predikatet er "grep-type", og gi det navnet "type" i tebellen/resultatet".* 

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
*Spørringen lister opp alle elementer som er "grep-type" i databasen.*

Vi kan også spørre om alle egenskaper/properties i databasen:

{%ace edit=false, check=false, lang='sql'%}
SELECT DISTINCT ?property
WHERE {
  ?s ?property ?o .
}
{%endace%}
...men det hjelper oss kanskje ikke til å finne ut hvilke egenskaper en bestemt type har. Men det gjør følgende spørring, som lister opp alle egenskapene til typen *kompetansemaal*:

{%ace edit=false, check=false, lang='sql'%}
PREFIX ontologi:<http://psi.udir.no/ontologi/kl06/>
SELECT DISTINCT ?egenskap
WHERE {
  ?s a ontologi:kompetansemaal ;
     ?egenskap ?o .
}
{%endace%}
som gir følgende resultat:

| **egenskap** |
| -- |
| http://www.w3.org/1999/02/22-rdf-syntax-ns#type |
| http://psi.udir.no/ontologi/kl06/grep-type |
| http://psi.udir.no/ontologi/kl06/id |
| http://psi.udir.no/ontologi/kl06/kode |
| http://psi.udir.no/ontologi/kl06/sist-endret |
| http://psi.udir.no/ontologi/kl06/status |
| http://psi.udir.no/ontologi/kl06/tittel |
| http://psi.udir.no/ontologi/kl06/uri |
| http://psi.udir.no/ontologi/kl06/url-data |
| http://psi.udir.no/ontologi/kl06/reversert/har-kompetansemaal |

Legg spesielt merke til den siste egenskapen i tabellen over. Her har vi en URL som avviker fra ontologien ved å tilføye "/reversert". Denne peker tilbake til en type som har en egenskap som heter "har-kompetansemaal". Hvis vi i ontologien slår opp http://psi.udir.no/ontologi/Kl06/har-kompetansemaal (uten "/reversert"), ser vi at det dreier seg om typen "kompetansemaalsett". Kompetansemålsett består altså av kompetansemål. Vi har lagt på /reversert-koblingen for at det skal være mulig å gå bakover fra kompetansemål til kompetansemålsett der det ikke eksplisitt er med i modellen. 

## Bruke det du har lært i pkt. 1 til å grave dypere (og bruke det videre til programmering)
Videre kan en gå fra kompetansemålsett til hovedområde (typen "hovedomraade"), og videre il læreplan ("laereplan"), osv. På den måten kan en bygge opp spørringer for å hente ut informasjon fra databasen.

For eksempel kan det være en utfordring å "finne veien" til læreplanen, fra en gitt fagkode direkte.
Denne spørringen gir svaret:

{%ace edit=false, check=false, lang='sql'%}
PREFIX grep: <http://psi.udir.no/kl06/>
PREFIX ontologi: <http://psi.udir.no/ontologi/kl06/>
PREFIX kode: <http://data.udir.no/kl06/>
SELECT ?fagkodetittel ?zkode ?ztittel ?kms ?lp ?laereplantittel  WHERE {
grep:NOR0214 ontologi:tittel ?fagkodetittel ;
ontologi:har-opplaeringsfag ?zkode ;
ontologi:status ?status
FILTER regex(?status, "publisert")
FILTER (lang(?fagkodetittel) = '').

?kms ontologi:har-etter-fag ?zkode .
?zkode ontologi:tittel ?ztittel.
FILTER (lang(?ztittel) = '')  .

?zkode ontologi:status ?zstatus
FILTER regex(?zstatus, "publisert") .

?kmslp ontologi:har-kompetansemaalsett ?kms ;
ontologi:status ?status
FILTER regex(?status, "publisert") .

?lp ontologi:uri ?kmslp .

?lp ontologi:tittel ?laereplantittel
FILTER (lang(?laereplantittel) = '')  .
}
{%endace%}

Her er en gjengivelse av spørringen, denne gangen med kommentarer og forklaringer:


...osv osv, eller skal dette inn i eksempel-kapittelet?

