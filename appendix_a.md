# Appendix A - Endringer i datagrunnlaget


## Hjelpedata
Det er gjort en del endringer i innholdet i hjelpedata i forbindelse med denne releasen. Alle hjelpedata har blitt merket med aktuell greptype, og har fått en unik kode. I denne prosessen ble det bestemt at Oppgave/Sensur skulle spittes opp i to hjepedatatyper. En for Oppgave og en for Sensur. I tillegg skulle hjelpedatatypene som var definert for spesifikke elevtype, elev eller privatist, gjøres om til en felles type som gjelde for alle elevtyper. Andre hjelpedatatyper ble omdøpt uten at eksisterende innhold ble endret eller at de ble erstattet av nye verdier.
### Oppgave/Sensur
Hjelpedatatypen Oppgave/Sensur utgår. Den erstattes av to nye typer, Oppgave og Sensur.
Det samme vil gjelde for hjelpedataene av denne typen.
* Lokal
* Sentral

Det vil si at PSI http://psi.udir.no/ontologi/oppgavesensur erstattes av
* http://grep.bouvet.no/psi/ontologi/kl06/oppgave i tilfellene der verdien gjelder oppgave.
  * Verdier for denne typen er:
   * http://psi.udir.no/kl06/oppgave_lokal
   * http://psi.udir.no/kl06/oppgave_sentral
* http://grep.bouvet.no/psi/ontologi/kl06/sensur i tilfelle verdien gjelder sensur
  * Verdier for denne typen er:
   * http://psi.udir.no/kl06/sensur_lokal
   * http://psi.udir.no/kl06/sensur_sentral


### Eksamensfag/Elev og Eksamensfag/Privatist
Eksamensfag/Elev og Eksamensfag/Privatist utgår. Disse erstattes av en ny type, Trekkordning
Det samme vil gjelde for alle hjelpedatatene av disse typene:
* http://psi.udir.no/eksamensfag/elev/6
* http://psi.udir.no/eksamensfag/elev/4
* http://psi.udir.no/eksamensfag/elev/3
* http://psi.udir.no/eksamensfag/elev/5
* http://psi.udir.no/eksamensfag/elev/10
* http://psi.udir.no/eksamensfag/elev/7
* http://psi.udir.no/eksamensfag/privatist/9
* http://psi.udir.no/eksamensfag/privatist/3
* http://psi.udir.no/eksamensfag/privatist/4
* http://psi.udir.no/eksamensfag/privatist/5
* http://psi.udir.no/eksamensfag/privatist/11
* http://psi.udir.no/eksamensfag/privatist/10
* 
Det vil si at PSI-ene http://psi.udir.no/ontologi/eksamensfag_elev og  http://psi.udir.no/ontologi/eksamensfag_privatist erstattes av nye verdier av typen http://grep.bouvet.no/psi/ontologi/kl06/trekkordning. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI |	Tittel |	Ny PSI |
| -- | -- | -- |
| http://psi.udir.no/eksamensfag/elev/3 http://psi.udir.no/eksamensfag/privatist/3 | Ingen eksamen | http://psi.udir.no/kl06/trekkordning_1 |
| http://psi.udir.no/eksamensfag/elev/7 http://psi.udir.no/eksamensfag/privatist/10	 | Trekkfag | http://psi.udir.no/kl06/trekkordning_2 | 
| http://psi.udir.no/eksamensfag/elev/5 http://psi.udir.no/eksamensfag/privatist/4 |	Obligatorisk | http://psi.udir.no/kl06/trekkordning_3 |
	
Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.
Eksamensordning/Elev og Eksamensordning/Privatist
Hjelpedatatypene Eksamensordning Elev og Eksamensordning Privatist utgår. Disse erstattes av en ny type, Eksamensordning.

Det samme vil gjelde for alle hjelpedataene av disse to typene:

* http://psi.udir.no/eksamensordning/elev/fagproeve
* http://psi.udir.no/eksamensordning/elev/fagproeve_skriftlig
* http://psi.udir.no/eksamensordning/elev/2
* http://psi.udir.no/eksamensordning/elev/3
* http://psi.udir.no/eksamensordning/elev/38
* http://psi.udir.no/eksamensordning/elev/4
* http://psi.udir.no/eksamensordning/elev/5
* http://psi.udir.no/eksamensordning/elev/6
* http://psi.udir.no/eksamensordning/elev/33
* http://psi.udir.no/eksamensordning/elev/7
* http://psi.udir.no/eksamensordning/elev/8
* http://psi.udir.no/eksamensordning/elev/9
* http://psi.udir.no/eksamensordning/elev/10
* http://psi.udir.no/eksamensordning/elev/36
* http://psi.udir.no/eksamensordning/elev/12
* http://psi.udir.no/eksamensordning/elev/11
* http://psi.udir.no/eksamensordning/elev/13
* http://psi.udir.no/eksamensordning/elev/14
* http://psi.udir.no/eksamensordning/elev/15
* http://psi.udir.no/eksamensordning/elev/16
* http://psi.udir.no/eksamensordning/elev/17
* http://psi.udir.no/eksamensordning/elev/18
* http://psi.udir.no/eksamensordning/elev/34
* http://psi.udir.no/eksamensordning/elev/35
* http://psi.udir.no/eksamensordning/elev/26
* http://psi.udir.no/eksamensordning/elev/28
* http://psi.udir.no/eksamensordning/elev/32
* http://psi.udir.no/eksamensordning/elev/19
* http://psi.udir.no/eksamensordning/elev/37
* http://psi.udir.no/eksamensordning/elev/20
* http://psi.udir.no/eksamensordning/elev/21
* http://psi.udir.no/eksamensordning/elev/22
* http://psi.udir.no/eksamensordning/elev/23
* http://psi.udir.no/eksamensordning/elev/24
* http://psi.udir.no/eksamensordning/elev/25
* http://psi.udir.no/eksamensordning/elev/27
* http://psi.udir.no/eksamensordning/elev/29
* http://psi.udir.no/eksamensordning/elev/30
* http://psi.udir.no/eksamensordning/elev/31
* http://psi.udir.no/eksamensordning/elev/skriftlig_muntlig
* http://psi.udir.no/eksamensordning/elev/svenneproeve
* http://psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig
* http://psi.udir.no/eksamensordning/elev/41
* http://psi.udir.no/eksamensordning/elev/39
* http://psi.udir.no/eksamensordning/elev/40
* http://psi.udir.no/eksamensordning/privatist/3
* http://psi.udir.no/eksamensordning/privatist/1
* http://psi.udir.no/eksamensordning/privatist/fagproeve
* http://psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig
* http://psi.udir.no/eksamensordning/privatist/2
* http://psi.udir.no/eksamensordning/privatist/28
* http://psi.udir.no/eksamensordning/privatist/5
* http://psi.udir.no/eksamensordning/privatist/4
* http://psi.udir.no/eksamensordning/privatist/6
* http://psi.udir.no/eksamensordning/privatist/8
* http://psi.udir.no/eksamensordning/privatist/7
* http://psi.udir.no/eksamensordning/privatist/9
* http://psi.udir.no/eksamensordning/privatist/10
* http://psi.udir.no/eksamensordning/privatist/11
* http://psi.udir.no/eksamensordning/privatist/12
* http://psi.udir.no/eksamensordning/privatist/31
* http://psi.udir.no/eksamensordning/privatist/21
* http://psi.udir.no/eksamensordning/privatist/23
* http://psi.udir.no/eksamensordning/privatist/27
* http://psi.udir.no/eksamensordning/privatist/16
* http://psi.udir.no/eksamensordning/privatist/18
* http://psi.udir.no/eksamensordning/privatist/13
* http://psi.udir.no/eksamensordning/privatist/15
* http://psi.udir.no/eksamensordning/privatist/14
* http://psi.udir.no/eksamensordning/privatist/29
* http://psi.udir.no/eksamensordning/privatist/17
* http://psi.udir.no/eksamensordning/privatist/19
* http://psi.udir.no/eksamensordning/privatist/20
* http://psi.udir.no/eksamensordning/privatist/34
* http://psi.udir.no/eksamensordning/privatist/32
* http://psi.udir.no/eksamensordning/privatist/33
* http://psi.udir.no/eksamensordning/privatist/22
* http://psi.udir.no/eksamensordning/privatist/24
* http://psi.udir.no/eksamensordning/privatist/skriftlig_muntlig
* http://psi.udir.no/eksamensordning/privatist/svenneproeve
* http://psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig
* http://psi.udir.no/eksamensordning/privatist/30
* http://psi.udir.no/eksamensordning/privatist/25
* http://psi.udir.no/eksamensordning/privatist/26
* http://psi.udir.no/eksamensordning/elev/skriftlig_eller_praktisk

Det vil si at PSI-ene http://psi.udir.no/ontologi/eksamensordning_elev og  http://psi.udir.no/ontologi/eksamensordning_privatist erstattes av nye verdier av typen http://grep.bouvet.no/psi/ontologi/kl06/eksamensordning. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI |	Tittel | Ny PSI |
| -- | -- | -- |
|http://psi.udir.no/eksamensordning/elev/4	|Ingen eksamen|	http://psi.udir.no/kl06/eksamensordning_1|
|http://psi.udir.no/eksamensordning/elev/10|	Muntlig og praktisk|	http://psi.udir.no/kl06/eksamensordning_2|
|http://psi.udir.no/eksamensordning/elev/11 http://psi.udir.no/eksamensordning/privatist/7|	Muntlig-praktisk|	http://psi.udir.no/kl06/eksamensordning_3|		
|http://psi.udir.no/eksamensordning/elev/13 http://psi.udir.no/eksamensordning/privatist/9|	Praktisk|	http://psi.udir.no/kl06/eksamensordning_4|
|http://psi.udir.no/eksamensordning/elev/19 http://psi.udir.no/eksamensordning/privatist/13		|Skriftlig|	http://psi.udir.no/kl06/eksamensordning_5|
|http://psi.udir.no/eksamensordning/elev/20	|Skriftlig eller muntlig|	http://psi.udir.no/kl06/eksamensordning_6|
|http://psi.udir.no/eksamensordning/elev/21	|Skriftlig eller muntlig-praktisk|	http://psi.udir.no/kl06/eksamensordning_7|
|http://psi.udir.no/eksamensordning/elev/27	|Skriftlig og/eller muntlig|	http://psi.udir.no/kl06/eksamensordning_8|
|http://psi.udir.no/eksamensordning/elev/37	|Skriftlig + ev. muntlig|	http://psi.udir.no/kl06/eksamensordning_9|
|http://psi.udir.no/eksamensordning/elev/38	|Hovedmål + ev. sidemål + ev. muntlig|	http://psi.udir.no/kl06/eksamensordning_10|
|http://psi.udir.no/eksamensordning/elev/39|	Tverrfaglig praktisk|	http://psi.udir.no/kl06/eksamensordning_11|
|http://psi.udir.no/eksamensordning/elev/40	|Tverrfaglig skriftlig|	http://psi.udir.no/kl06/eksamensordning_12|
|http://psi.udir.no/eksamensordning/elev/7 http://psi.udir.no/eksamensordning/privatist/4|	Muntlig|	http://psi.udir.no/kl06/eksamensordning_13|
|http://psi.udir.no/eksamensordning/elev/fagproeve	|Fagprøve|	http://psi.udir.no/kl06/eksamensordning_14|
|http://psi.udir.no/eksamensordning/elev/fagproeve_skriftlig http://psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig|	Fagprøve + skriftlig|	http://psi.udir.no/kl06/eksamensordning_15|
|		 http://psi.udir.no/eksamensordning/elev/skriftlig_muntlig	http://psi.udir.no/eksamensordning/privatist/skriftlig_muntlig|Skriftlig-muntlig|	http://psi.udir.no/kl06/eksamensordning_16|
|http://psi.udir.no/eksamensordning/elev/svenneproeve|	Svenneprøve|	http://psi.udir.no/kl06/eksamensordning_17|
|http://psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig http://psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig		|Svenneprøve + skriftlig	|http://psi.udir.no/kl06/eksamensordning_18|
|http://psi.udir.no/eksamensordning/privatist/17	|Skriftlig og muntlig|	http://psi.udir.no/kl06/eksamensordning_19|
|http://psi.udir.no/eksamensordning/privatist/19	|Skriftlig og muntlig-praktisk|	http://psi.udir.no/kl06/eksamensordning_20|

http://psi.udir.no/eksamensordning/privatist/2	Hov.mål+Sid.mål sk+muntl	http://psi.udir.no/kl06/eksamensordning_21

http://psi.udir.no/eksamensordning/privatist/32	Skriftlig og tverrfaglig praktisk	http://psi.udir.no/kl06/eksamensordning_23

http://psi.udir.no/eksamensordning/privatist/33	Skriftlig og tverrfaglig skriftlig	http://psi.udir.no/kl06/eksamensordning_24

http://psi.udir.no/eksamensordning/privatist/34	Skriftlig og tverrfaglig muntlig-praktisk	http://psi.udir.no/kl06/eksamensordning_25


Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.
Vurderingsform
Vurderingsform har endret navn til Vurderingsuttrykk. Denne endringen påvirker kun nye verdier som greptype og kode for eksisterende element.
