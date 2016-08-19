# Appendix A - Endringer i datagrunnlaget


## Hjelpedata
Det er gjort en del endringer i innholdet i hjelpedata i forbindelse med denne releasen. Alle hjelpedata har blitt merket med aktuell greptype, og har fått en unik kode. I denne prosessen ble det bestemt at Oppgave/Sensur skulle spittes opp i to hjepedatatyper. En for Oppgave og en for Sensur. I tillegg skulle hjelpedatatypene som var definert for spesifikke elevtype, elev eller privatist, gjøres om til en felles type som gjelde for alle elevtyper. Andre hjelpedatatyper ble omdøpt uten at eksisterende innhold ble endret eller at de ble erstattet av nye verdier.
### Oppgave/Sensur
Hjelpedatatypen Oppgave/Sensur utgår. Den erstattes av to nye typer, Oppgave og Sensur.
Det samme vil gjelde for hjelpedataene av denne typen.
* Lokal
* Sentral

Det vil si at PSI *psi.udir.no/ontologi/oppgavesensur* erstattes av
* *grep.bouvet.no/psi/ontologi/kl06/oppgave* i tilfellene der verdien gjelder oppgave.
  * Verdier for denne typen er:
   * *psi.udir.no/kl06/oppgave_lokal*
   * *psi.udir.no/kl06/oppgave_sentral*
* *grep.bouvet.no/psi/ontologi/kl06/sensur* i tilfelle verdien gjelder sensur
  * Verdier for denne typen er:
   * *psi.udir.no/kl06/sensur_lokal*
   * *psi.udir.no/kl06/sensur_sentral*


### Eksamensfag/Elev og Eksamensfag/Privatist
Eksamensfag/Elev og Eksamensfag/Privatist utgår. Disse erstattes av en ny type, Trekkordning
Det samme vil gjelde for alle hjelpedatatene av disse typene:
* *psi.udir.no/eksamensfag/elev/6*
* *psi.udir.no/eksamensfag/elev/4*
* *psi.udir.no/eksamensfag/elev/3*
* *psi.udir.no/eksamensfag/elev/5*
* *psi.udir.no/eksamensfag/elev/10*
* *psi.udir.no/eksamensfag/elev/7*
* *psi.udir.no/eksamensfag/privatist/9*
* *psi.udir.no/eksamensfag/privatist/3*
* *psi.udir.no/eksamensfag/privatist/4*
* *psi.udir.no/eksamensfag/privatist/5*
* *psi.udir.no/eksamensfag/privatist/11*
* *psi.udir.no/eksamensfag/privatist/10*
* 
Det vil si at PSI-ene *psi.udir.no/ontologi/eksamensfag_elev* og  *psi.udir.no/ontologi/eksamensfag_privatist* erstattes av nye verdier av typen *grep.bouvet.no/psi/ontologi/kl06/trekkordning*. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI |	Tittel |	Ny PSI |
| -- | -- | -- |
| *psi.udir.no/eksamensfag/elev/3* *psi.udir.no/eksamensfag/privatist/3* | Ingen eksamen | *psi.udir.no/kl06/trekkordning_1* |
| *psi.udir.no/eksamensfag/elev/7* *psi.udir.no/eksamensfag/privatist/10*	 | Trekkfag | *psi.udir.no/kl06/trekkordning_2* | 
| *psi.udir.no/eksamensfag/elev/5* *psi.udir.no/eksamensfag/privatist/4* |	Obligatorisk | *psi.udir.no/kl06/trekkordning_3* |
	
Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.
###Eksamensordning/Elev og Eksamensordning/Privatist
Hjelpedatatypene Eksamensordning Elev og Eksamensordning Privatist utgår. Disse erstattes av en ny type, Eksamensordning.

Det samme vil gjelde for alle hjelpedataene av disse to typene:

* *psi.udir.no/eksamensordning/elev/fagproeve*
* *psi.udir.no/eksamensordning/elev/fagproeve_skriftlig*
* *psi.udir.no/eksamensordning/elev/2*
* *psi.udir.no/eksamensordning/elev/3*
* *psi.udir.no/eksamensordning/elev/38*
* *psi.udir.no/eksamensordning/elev/4*
* *psi.udir.no/eksamensordning/elev/5*
* *psi.udir.no/eksamensordning/elev/6*
* *psi.udir.no/eksamensordning/elev/33*
* *psi.udir.no/eksamensordning/elev/7*
* *psi.udir.no/eksamensordning/elev/8*
* *psi.udir.no/eksamensordning/elev/9*
* *psi.udir.no/eksamensordning/elev/10*
* *psi.udir.no/eksamensordning/elev/36*
* *psi.udir.no/eksamensordning/elev/12*
* *psi.udir.no/eksamensordning/elev/11*
* *psi.udir.no/eksamensordning/elev/13*
* *psi.udir.no/eksamensordning/elev/14*
* *psi.udir.no/eksamensordning/elev/15*
* *psi.udir.no/eksamensordning/elev/16*
* *psi.udir.no/eksamensordning/elev/17*
* *psi.udir.no/eksamensordning/elev/18*
* *psi.udir.no/eksamensordning/elev/34*
* *psi.udir.no/eksamensordning/elev/35*
* *psi.udir.no/eksamensordning/elev/26*
* *psi.udir.no/eksamensordning/elev/28*
* *psi.udir.no/eksamensordning/elev/32*
* *psi.udir.no/eksamensordning/elev/19*
* *psi.udir.no/eksamensordning/elev/37*
* *psi.udir.no/eksamensordning/elev/20*
* *psi.udir.no/eksamensordning/elev/21*
* *psi.udir.no/eksamensordning/elev/22*
* *psi.udir.no/eksamensordning/elev/23*
* *psi.udir.no/eksamensordning/elev/24*
* *psi.udir.no/eksamensordning/elev/25*
* *psi.udir.no/eksamensordning/elev/27*
* *psi.udir.no/eksamensordning/elev/29*
* *psi.udir.no/eksamensordning/elev/30*
* *psi.udir.no/eksamensordning/elev/31*
* *psi.udir.no/eksamensordning/elev/skriftlig_muntlig*
* *psi.udir.no/eksamensordning/elev/svenneproeve*
* *psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig*
* *psi.udir.no/eksamensordning/elev/41*
* *psi.udir.no/eksamensordning/elev/39*
* *psi.udir.no/eksamensordning/elev/40*
* *psi.udir.no/eksamensordning/privatist/3*
* *psi.udir.no/eksamensordning/privatist/1*
* *psi.udir.no/eksamensordning/privatist/fagproeve*
* *psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig*
* *psi.udir.no/eksamensordning/privatist/2*
* *psi.udir.no/eksamensordning/privatist/28*
* *psi.udir.no/eksamensordning/privatist/5*
* *psi.udir.no/eksamensordning/privatist/4*
* *psi.udir.no/eksamensordning/privatist/6*
* *psi.udir.no/eksamensordning/privatist/8*
* *psi.udir.no/eksamensordning/privatist/7*
* *psi.udir.no/eksamensordning/privatist/9*
* *psi.udir.no/eksamensordning/privatist/10*
* *psi.udir.no/eksamensordning/privatist/11*
* *psi.udir.no/eksamensordning/privatist/12*
* *psi.udir.no/eksamensordning/privatist/31*
* *psi.udir.no/eksamensordning/privatist/21*
* *psi.udir.no/eksamensordning/privatist/23*
* *psi.udir.no/eksamensordning/privatist/27*
* *psi.udir.no/eksamensordning/privatist/16*
* *psi.udir.no/eksamensordning/privatist/18*
* *psi.udir.no/eksamensordning/privatist/13*
* *psi.udir.no/eksamensordning/privatist/15*
* *psi.udir.no/eksamensordning/privatist/14*
* *psi.udir.no/eksamensordning/privatist/29*
* *psi.udir.no/eksamensordning/privatist/17*
* *psi.udir.no/eksamensordning/privatist/19*
* *psi.udir.no/eksamensordning/privatist/20*
* *psi.udir.no/eksamensordning/privatist/34*
* *psi.udir.no/eksamensordning/privatist/32*
* *psi.udir.no/eksamensordning/privatist/33*
* *psi.udir.no/eksamensordning/privatist/22*
* *psi.udir.no/eksamensordning/privatist/24*
* *psi.udir.no/eksamensordning/privatist/skriftlig_muntlig*
* *psi.udir.no/eksamensordning/privatist/svenneproeve*
* *psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig*
* *psi.udir.no/eksamensordning/privatist/30*
* *psi.udir.no/eksamensordning/privatist/25*
* *psi.udir.no/eksamensordning/privatist/26*
* *psi.udir.no/eksamensordning/elev/skriftlig_eller_praktisk*

Det vil si at PSI-ene *psi.udir.no/ontologi/eksamensordning_elev* og  *psi.udir.no/ontologi/eksamensordning_privatist* erstattes av nye verdier av typen *grep.bouvet.no/psi/ontologi/kl06/eksamensordning*. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI |	Tittel | Ny PSI |
| -- | -- | -- |
|*psi.udir.no/eksamensordning/elev/4*	|Ingen eksamen|	*psi.udir.no/kl06/eksamensordning_1*|
|*psi.udir.no/eksamensordning/elev/10*|	Muntlig og praktisk|	*psi.udir.no/kl06/eksamensordning_2*|
|*psi.udir.no/eksamensordning/elev/11* *psi.udir.no/eksamensordning/privatist/7*|	Muntlig-praktisk|	*psi.udir.no/kl06/eksamensordning_3*|		
|*psi.udir.no/eksamensordning/elev/13* *psi.udir.no/eksamensordning/privatist/9*|	Praktisk|	*psi.udir.no/kl06/eksamensordning_4*|
|*psi.udir.no/eksamensordning/elev/19* *psi.udir.no/eksamensordning/privatist/13*		|Skriftlig|	*psi.udir.no/kl06/eksamensordning_5*|
|*psi.udir.no/eksamensordning/elev/20*	|Skriftlig eller muntlig|	*psi.udir.no/kl06/eksamensordning_6*|
|*psi.udir.no/eksamensordning/elev/21*	|Skriftlig eller muntlig-praktisk|	*psi.udir.no/kl06/eksamensordning_7*|
|*psi.udir.no/eksamensordning/elev/27*	|Skriftlig og/eller muntlig|	*psi.udir.no/kl06/eksamensordning_8*|
|*psi.udir.no/eksamensordning/elev/37*	|Skriftlig + ev. muntlig|	*psi.udir.no/kl06/eksamensordning_9*|
|*psi.udir.no/eksamensordning/elev/38*	|Hovedmål + ev. sidemål + ev. muntlig|	*psi.udir.no/kl06/eksamensordning_10*|
|*psi.udir.no/eksamensordning/elev/39*|	Tverrfaglig praktisk|	*psi.udir.no/kl06/eksamensordning_11*|
|*psi.udir.no/eksamensordning/elev/40*	|Tverrfaglig skriftlig|	*psi.udir.no/kl06/eksamensordning_12*|
|*psi.udir.no/eksamensordning/elev/7* *psi.udir.no/eksamensordning/privatist/4*|	Muntlig|	*psi.udir.no/kl06/eksamensordning_13*|
|*psi.udir.no/eksamensordning/elev/fagproeve*	|Fagprøve|	*psi.udir.no/kl06/eksamensordning_14*|
|*psi.udir.no/eksamensordning/elev/fagproeve_skriftlig* *psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig*|	Fagprøve + skriftlig|	*psi.udir.no/kl06/eksamensordning_15*|
|		 *psi.udir.no/eksamensordning/elev/skriftlig_muntlig	*psi.udir.no/eksamensordning/privatist/skriftlig_muntlig|Skriftlig-muntlig|	*psi.udir.no/kl06/eksamensordning_16|
|*psi.udir.no/eksamensordning/elev/svenneproeve|	Svenneprøve|	*psi.udir.no/kl06/eksamensordning_17|
|*psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig *psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig		|Svenneprøve + skriftlig	|*psi.udir.no/kl06/eksamensordning_18|
|*psi.udir.no/eksamensordning/privatist/17	|Skriftlig og muntlig|	*psi.udir.no/kl06/eksamensordning_19|
|*psi.udir.no/eksamensordning/privatist/19	|Skriftlig og muntlig-praktisk|	*psi.udir.no/kl06/eksamensordning_20|
|*psi.udir.no/eksamensordning/privatist/2	|Hov.mål+Sid.mål sk+muntl|	*psi.udir.no/kl06/eksamensordning_21|
|*psi.udir.no/eksamensordning/privatist/32	|Skriftlig og tverrfaglig praktisk	|*psi.udir.no/kl06/eksamensordning_23|
|*psi.udir.no/eksamensordning/privatist/33	|Skriftlig og tverrfaglig| skriftlig	*psi.udir.no/kl06/eksamensordning_24|
|*psi.udir.no/eksamensordning/privatist/34	|Skriftlig og tverrfaglig muntlig-praktisk	|*psi.udir.no/kl06/eksamensordning_25|

Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.
###Vurderingsform
Vurderingsform har endret navn til Vurderingsuttrykk. Denne endringen påvirker kun nye verdier som greptype og kode for eksisterende element.
