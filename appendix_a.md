# Appendix A - Endringer i datagrunnlaget
Endringer i datagrunnlag knyttet til tidligere versjoner er tilgjengelig [her](https://kl06-doc.gitbooks.io/kl06-public/content/appendix_a.html).

## Merkelapper
Koblinger til merkelapper er utvidet til å ha med gyldighetsperiode. Dette blir tilgjengelig på merkelapp-elementet og på tilhørende læreplan, fagkode, opplæringsfag eller programområde.

## Merknader
Merknadens koblinger til relaterte årstrinn og opplæringsnivå er endret til å være av type referanse.

## Hjelpedata
Hjelpedata er i 201604 benyttet som en samleklasse for et sett av hjelpedatatyper. Problemet med denne løsningen var at eventuelle endringer og utvidelser måtte gjøres for alle elmenttype. Noe som ikke var ønskelig når fagtype skulle utvides med kortform.
Derfor ble Hjelpedata splittet opp, og det ble laget nye klasser for hver av de underliggende elementtypene.

###Fagtype
Fagtype er utvidet med kobling til opplæringsnivå og kortform-felt.
Et eksempel på dette er [fellsefag](http://beta-data.udir.no/kl06/fagtype_fellesfag).

###Generell effekt av denne endringe
I Rest og Odata er det i praksis ingen brudd knyttet til denne endringen.
Men i soap vil disse endringene være mer synlig, og gi kontraktsbrudd. Mer info knyttet til dette finner du [her]https://kl06-doc.gitbooks.io/kl06-public/content/v/beta/appendix_b.html).





