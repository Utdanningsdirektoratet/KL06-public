# SPARQL-endepunktet
I dette kapittelet vil vi mer eller mindre rett på sak, og vise hvordan du bruke Greps SPARQL-endepunkt
- til å skaffe deg oversikt over hvilke data som er tilgjengelig via dette grensesnittet 
- kjøre spørringer som du kan bruke videre i programmering

Grudigere dokumentasjon om SPARQL generelt, kan du finne på [W3C](https://www.w3.org/TR/sparql11-overview/) sine sider.

Greps SPARQL-grensesnitt nås på endepunktet [http://data.udir.no/kl06/sparql/](http://data.udir.no/kl06/sparql/):
![SPARQL-endepunktet](sparql-endepunktet.png)
*Forsiden til SPARQL-endepunkt med ferdig utfylt spørring: "Vis meg hvilke konsepter du har" (velg hvilket format du ønsker resultatet i, og klikk "Run Query")*

Resultatet av denne "standard-spørringen" lister opp alle "konsepter" som er tilgjengelige via Greps SPARQL-grensesnitt. Her vil eksterne skjemaer (som f.eks. http://www.openlinksw.com/schemas) eller ontologier (f. eks. http://www.w3.org/2002/07/owl#Ontology) listes opp sammen med Greps egne Typer.

Du kan også spørre eksplisitt om typene i Grep ved å kjøre følgende spørring:

{%ace edit=false, check=false, lang='xml'%}
SELECT * WHERE {
?s <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> ?o
}
```
Denne returnerer alle elementer i Grep som er definert som RDF-"type" i følge skjemaet til W3C.

Det samme resultatet får du ved å spørre om det samme, men i følge Greps egen ontologi:
```SELECT * WHERE {
?s <http://psi.udir.no/ontologi/#type> ?o
}
{%endace%}
