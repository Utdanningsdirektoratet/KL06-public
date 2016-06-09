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

| Gammel PSI | 1:0 | 2:0 |
| -- | -- | -- |
| 0:2 | 1:2 | 2:2 |
| 0:3 | 1:3 | 2:3 |

|Gammel PSI |	Tittel |	Ny PSI |
| -- | -- | -- |
| http://psi.udir.no/eksamensfag/elev/3 http://psi.udir.no/eksamensfag/privatist/3 | Ingen eksamen | http://psi.udir.no/kl06/trekkordning_1 |
| http://psi.udir.no/eksamensfag/elev/7 http://psi.udir.no/eksamensfag/privatist/10	 | Trekkfag | http://psi.udir.no/kl06/trekkordning_2 | 
| http://psi.udir.no/eksamensfag/elev/5 http://psi.udir.no/eksamensfag/privatist/4 |	Obligatorisk | http://psi.udir.no/kl06/trekkordning_3 |
	
