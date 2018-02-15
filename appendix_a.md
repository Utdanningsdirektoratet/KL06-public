# Appendix A - Endringer i datagrunnlaget

## Hjelpedata

Det er gjort en del endringer i innholdet i hjelpedata i forbindelse med denne releasen. Alle hjelpedata har blitt merket med aktuell greptype, og har fått en unik kode. I denne prosessen ble det bestemt at Oppgave/Sensur skulle spittes opp i to hjepedatatyper. En for Oppgave og en for Sensur. I tillegg skulle hjelpedatatypene som var definert for spesifikke elevtype, elev eller privatist, gjøres om til en felles type som gjelde for alle elevtyper. Andre hjelpedatatyper ble omdøpt uten at eksisterende innhold ble endret eller at de ble erstattet av nye verdier.

### Oppgave/Sensur

Hjelpedatatypen Oppgave/Sensur utgår. Den erstattes av to nye typer, Oppgave og Sensur.  
Det samme vil gjelde for hjelpedataene av denne typen.

* Lokal
* Sentral

Det vil si at PSI [http://beta-psi.udir.no/ontologi/oppgavesensur](http://beta-psi.udir.no/ontologi/oppgavesensur) erstattes av

* [http://beta-psi.udir.no/ontologi/kl06/oppgave](http://beta-psi.udir.no/ontologi/kl06/oppgave) i tilfellene der verdien gjelder oppgave.
  * Verdier for denne typen er:
    * [http://beta-psi.udir.no/kl06/oppgave\_lokal](http://beta-psi.udir.no/kl06/oppgave_lokal)
    * [http://beta-psi.udir.no/kl06/oppgave\_sentral](http://beta-psi.udir.no/kl06/oppgave_sentral)
* [http://beta-psi.udir.no/ontologi/kl06/sensur](http://beta-psi.udir.no/ontologi/kl06/sensur) i tilfelle verdien gjelder sensur
  * Verdier for denne typen er:
    * [http://beta-psi.udir.no/kl06/sensur\_lokal](http://beta-psi.udir.no/kl06/sensur_lokal)
    * [http://beta-psi.udir.no/kl06/sensur\_sentral](http://beta-psi.udir.no/kl06/sensur_sentral)

### Eksamensfag/Elev og Eksamensfag/Privatist

Eksamensfag/Elev og Eksamensfag/Privatist utgår. Disse erstattes av en ny type, Trekkordning  
Det samme vil gjelde for alle hjelpedatatene av disse typene:

* [http://beta-psi.udir.no/eksamensfag/elev/6](http://beta-psi.udir.no/eksamensfag/elev/6)
* [http://beta-psi.udir.no/eksamensfag/elev/4](http://beta-psi.udir.no/eksamensfag/elev/4)
* [http://beta-psi.udir.no/eksamensfag/elev/3](http://beta-psi.udir.no/eksamensfag/elev/3)
* [http://beta-psi.udir.no/eksamensfag/elev/5](http://beta-psi.udir.no/eksamensfag/elev/5)
* [http://beta-psi.udir.no/eksamensfag/elev/10](http://beta-psi.udir.no/eksamensfag/elev/10)
* [http://beta-psi.udir.no/eksamensfag/elev/7](http://beta-psi.udir.no/eksamensfag/elev/7)
* [http://beta-psi.udir.no/eksamensfag/privatist/9](http://beta-psi.udir.no/eksamensfag/privatist/9)
* [http://beta-psi.udir.no/eksamensfag/privatist/3](http://beta-psi.udir.no/eksamensfag/privatist/3)
* [http://beta-psi.udir.no/eksamensfag/privatist/4](http://beta-psi.udir.no/eksamensfag/privatist/4)
* [http://beta-psi.udir.no/eksamensfag/privatist/5](http://beta-psi.udir.no/eksamensfag/privatist/5)
* [http://beta-psi.udir.no/eksamensfag/privatist/11](http://beta-psi.udir.no/eksamensfag/privatist/11)
* [http://beta-psi.udir.no/eksamensfag/privatist/10](http://beta-psi.udir.no/eksamensfag/privatist/10)
* Det vil si at PSI-ene [http://beta-psi.udir.no/ontologi/eksamensfag\_elev](http://beta-psi.udir.no/ontologi/eksamensfag_elev) og  [http://beta-psi.udir.no/ontologi/eksamensfag\_privatist](http://beta-psi.udir.no/ontologi/eksamensfag_privatist) erstattes av nye verdier av typen [http://beta-psi.udir.no/ontologi/kl06/trekkordning](http://beta-psi.udir.no/ontologi/kl06/trekkordning). Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI | Tittel | Ny PSI |
| --- | --- | --- |
| [http://beta-psi.udir.no/eksamensfag/elev/3](http://beta-psi.udir.no/eksamensfag/elev/3) [http://beta-psi.udir.no/eksamensfag/privatist/3](http://beta-psi.udir.no/eksamensfag/privatist/3) | Ingen eksamen | [http://beta-psi.udir.no/kl06/trekkordning\_1](http://beta-psi.udir.no/kl06/trekkordning_1) |
| [http://beta-psi.udir.no/eksamensfag/elev/7](http://beta-psi.udir.no/eksamensfag/elev/7) [http://beta-psi.udir.no/eksamensfag/privatist/10](http://beta-psi.udir.no/eksamensfag/privatist/10) | Trekkfag | [http://beta-psi.udir.no/kl06/trekkordning\_2](http://beta-psi.udir.no/kl06/trekkordning_2) |
| [http://beta-psi.udir.no/eksamensfag/elev/5](http://beta-psi.udir.no/eksamensfag/elev/5) [http://beta-psi.udir.no/eksamensfag/privatist/4](http://beta-psi.udir.no/eksamensfag/privatist/4) | Obligatorisk | [http://beta-psi.udir.no/kl06/trekkordning\_3](http://beta-psi.udir.no/kl06/trekkordning_3) |

Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.

### Eksamensordning/Elev og Eksamensordning/Privatist

Hjelpedatatypene Eksamensordning Elev og Eksamensordning Privatist utgår. Disse erstattes av en ny type, Eksamensordning.

Det samme vil gjelde for alle hjelpedataene av disse to typene:

* [http://beta-psi.udir.no/eksamensordning/elev/fagproeve](http://beta-psi.udir.no/eksamensordning/elev/fagproeve)
* [http://beta-psi.udir.no/eksamensordning/elev/fagproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/elev/fagproeve_skriftlig)
* [http://beta-psi.udir.no/eksamensordning/elev/2](http://beta-psi.udir.no/eksamensordning/elev/2)
* [http://beta-psi.udir.no/eksamensordning/elev/3](http://beta-psi.udir.no/eksamensordning/elev/3)
* [http://beta-psi.udir.no/eksamensordning/elev/38](http://beta-psi.udir.no/eksamensordning/elev/38)
* [http://beta-psi.udir.no/eksamensordning/elev/4](http://beta-psi.udir.no/eksamensordning/elev/4)
* [http://beta-psi.udir.no/eksamensordning/elev/5](http://beta-psi.udir.no/eksamensordning/elev/5)
* [http://beta-psi.udir.no/eksamensordning/elev/6](http://beta-psi.udir.no/eksamensordning/elev/6)
* [http://beta-psi.udir.no/eksamensordning/elev/33](http://beta-psi.udir.no/eksamensordning/elev/33)
* [http://beta-psi.udir.no/eksamensordning/elev/7](http://beta-psi.udir.no/eksamensordning/elev/7)
* [http://beta-psi.udir.no/eksamensordning/elev/8](http://beta-psi.udir.no/eksamensordning/elev/8)
* [http://beta-psi.udir.no/eksamensordning/elev/9](http://beta-psi.udir.no/eksamensordning/elev/9)
* [http://beta-psi.udir.no/eksamensordning/elev/10](http://beta-psi.udir.no/eksamensordning/elev/10)
* [http://beta-psi.udir.no/eksamensordning/elev/36](http://beta-psi.udir.no/eksamensordning/elev/36)
* [http://beta-psi.udir.no/eksamensordning/elev/12](http://beta-psi.udir.no/eksamensordning/elev/12)
* [http://beta-psi.udir.no/eksamensordning/elev/11](http://beta-psi.udir.no/eksamensordning/elev/11)
* [http://beta-psi.udir.no/eksamensordning/elev/13](http://beta-psi.udir.no/eksamensordning/elev/13)
* [http://beta-psi.udir.no/eksamensordning/elev/14](http://beta-psi.udir.no/eksamensordning/elev/14)
* [http://beta-psi.udir.no/eksamensordning/elev/15](http://beta-psi.udir.no/eksamensordning/elev/15)
* [http://beta-psi.udir.no/eksamensordning/elev/16](http://beta-psi.udir.no/eksamensordning/elev/16)
* [http://beta-psi.udir.no/eksamensordning/elev/17](http://beta-psi.udir.no/eksamensordning/elev/17)
* [http://beta-psi.udir.no/eksamensordning/elev/18](http://beta-psi.udir.no/eksamensordning/elev/18)
* [http://beta-psi.udir.no/eksamensordning/elev/34](http://beta-psi.udir.no/eksamensordning/elev/34)
* [http://beta-psi.udir.no/eksamensordning/elev/35](http://beta-psi.udir.no/eksamensordning/elev/35)
* [http://beta-psi.udir.no/eksamensordning/elev/26](http://beta-psi.udir.no/eksamensordning/elev/26)
* [http://beta-psi.udir.no/eksamensordning/elev/28](http://beta-psi.udir.no/eksamensordning/elev/28)
* [http://beta-psi.udir.no/eksamensordning/elev/32](http://beta-psi.udir.no/eksamensordning/elev/32)
* [http://beta-psi.udir.no/eksamensordning/elev/19](http://beta-psi.udir.no/eksamensordning/elev/19)
* [http://beta-psi.udir.no/eksamensordning/elev/37](http://beta-psi.udir.no/eksamensordning/elev/37)
* [http://beta-psi.udir.no/eksamensordning/elev/20](http://beta-psi.udir.no/eksamensordning/elev/20)
* [http://beta-psi.udir.no/eksamensordning/elev/21](http://beta-psi.udir.no/eksamensordning/elev/21)
* [http://beta-psi.udir.no/eksamensordning/elev/22](http://beta-psi.udir.no/eksamensordning/elev/22)
* [http://beta-psi.udir.no/eksamensordning/elev/23](http://beta-psi.udir.no/eksamensordning/elev/23)
* [http://beta-psi.udir.no/eksamensordning/elev/24](http://beta-psi.udir.no/eksamensordning/elev/24)
* [http://beta-psi.udir.no/eksamensordning/elev/25](http://beta-psi.udir.no/eksamensordning/elev/25)
* [http://beta-psi.udir.no/eksamensordning/elev/27](http://beta-psi.udir.no/eksamensordning/elev/27)
* [http://beta-psi.udir.no/eksamensordning/elev/29](http://beta-psi.udir.no/eksamensordning/elev/29)
* [http://beta-psi.udir.no/eksamensordning/elev/30](http://beta-psi.udir.no/eksamensordning/elev/30)
* [http://beta-psi.udir.no/eksamensordning/elev/31](http://beta-psi.udir.no/eksamensordning/elev/31)
* [http://beta-psi.udir.no/eksamensordning/elev/skriftlig\_muntlig](http://beta-psi.udir.no/eksamensordning/elev/skriftlig_muntlig)
* [http://beta-psi.udir.no/eksamensordning/elev/svenneproeve](http://beta-psi.udir.no/eksamensordning/elev/svenneproeve)
* [http://beta-psi.udir.no/eksamensordning/elev/svenneproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig)
* [http://beta-psi.udir.no/eksamensordning/elev/41](http://beta-psi.udir.no/eksamensordning/elev/41)
* [http://beta-psi.udir.no/eksamensordning/elev/39](http://beta-psi.udir.no/eksamensordning/elev/39)
* [http://beta-psi.udir.no/eksamensordning/elev/40](http://beta-psi.udir.no/eksamensordning/elev/40)
* [http://beta-psi.udir.no/eksamensordning/privatist/3](http://beta-psi.udir.no/eksamensordning/privatist/3)
* [http://beta-psi.udir.no/eksamensordning/privatist/1](http://beta-psi.udir.no/eksamensordning/privatist/1)
* [http://beta-psi.udir.no/eksamensordning/privatist/fagproeve](http://beta-psi.udir.no/eksamensordning/privatist/fagproeve)
* [http://beta-psi.udir.no/eksamensordning/privatist/fagproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig)
* [http://beta-psi.udir.no/eksamensordning/privatist/2](http://beta-psi.udir.no/eksamensordning/privatist/2)
* [http://beta-psi.udir.no/eksamensordning/privatist/28](http://beta-psi.udir.no/eksamensordning/privatist/28)
* [http://beta-psi.udir.no/eksamensordning/privatist/5](http://beta-psi.udir.no/eksamensordning/privatist/5)
* [http://beta-psi.udir.no/eksamensordning/privatist/4](http://beta-psi.udir.no/eksamensordning/privatist/4)
* [http://beta-psi.udir.no/eksamensordning/privatist/6](http://beta-psi.udir.no/eksamensordning/privatist/6)
* [http://beta-psi.udir.no/eksamensordning/privatist/8](http://beta-psi.udir.no/eksamensordning/privatist/8)
* [http://beta-psi.udir.no/eksamensordning/privatist/7](http://beta-psi.udir.no/eksamensordning/privatist/7)
* [http://beta-psi.udir.no/eksamensordning/privatist/9](http://beta-psi.udir.no/eksamensordning/privatist/9)
* [http://beta-psi.udir.no/eksamensordning/privatist/10](http://beta-psi.udir.no/eksamensordning/privatist/10)
* [http://beta-psi.udir.no/eksamensordning/privatist/11](http://beta-psi.udir.no/eksamensordning/privatist/11)
* [http://beta-psi.udir.no/eksamensordning/privatist/12](http://beta-psi.udir.no/eksamensordning/privatist/12)
* [http://beta-psi.udir.no/eksamensordning/privatist/31](http://beta-psi.udir.no/eksamensordning/privatist/31)
* [http://beta-psi.udir.no/eksamensordning/privatist/21](http://beta-psi.udir.no/eksamensordning/privatist/21)
* [http://beta-psi.udir.no/eksamensordning/privatist/23](http://beta-psi.udir.no/eksamensordning/privatist/23)
* [http://beta-psi.udir.no/eksamensordning/privatist/27](http://beta-psi.udir.no/eksamensordning/privatist/27)
* [http://beta-psi.udir.no/eksamensordning/privatist/16](http://beta-psi.udir.no/eksamensordning/privatist/16)
* [http://beta-psi.udir.no/eksamensordning/privatist/18](http://beta-psi.udir.no/eksamensordning/privatist/18)
* [http://beta-psi.udir.no/eksamensordning/privatist/13](http://beta-psi.udir.no/eksamensordning/privatist/13)
* [http://beta-psi.udir.no/eksamensordning/privatist/15](http://beta-psi.udir.no/eksamensordning/privatist/15)
* [http://beta-psi.udir.no/eksamensordning/privatist/14](http://beta-psi.udir.no/eksamensordning/privatist/14)
* [http://beta-psi.udir.no/eksamensordning/privatist/29](http://beta-psi.udir.no/eksamensordning/privatist/29)
* [http://beta-psi.udir.no/eksamensordning/privatist/17](http://beta-psi.udir.no/eksamensordning/privatist/17)
* [http://beta-psi.udir.no/eksamensordning/privatist/19](http://beta-psi.udir.no/eksamensordning/privatist/19)
* [http://beta-psi.udir.no/eksamensordning/privatist/20](http://beta-psi.udir.no/eksamensordning/privatist/20)
* [http://beta-psi.udir.no/eksamensordning/privatist/34](http://beta-psi.udir.no/eksamensordning/privatist/34)
* [http://beta-psi.udir.no/eksamensordning/privatist/32](http://beta-psi.udir.no/eksamensordning/privatist/32)
* [http://beta-psi.udir.no/eksamensordning/privatist/33](http://beta-psi.udir.no/eksamensordning/privatist/33)
* [http://beta-psi.udir.no/eksamensordning/privatist/22](http://beta-psi.udir.no/eksamensordning/privatist/22)
* [http://beta-psi.udir.no/eksamensordning/privatist/24](http://beta-psi.udir.no/eksamensordning/privatist/24)
* [http://beta-psi.udir.no/eksamensordning/privatist/skriftlig\_muntlig](http://beta-psi.udir.no/eksamensordning/privatist/skriftlig_muntlig)
* [http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve](http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve)
* [http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig)
* [http://beta-psi.udir.no/eksamensordning/privatist/30](http://beta-psi.udir.no/eksamensordning/privatist/30)
* [http://beta-psi.udir.no/eksamensordning/privatist/25](http://beta-psi.udir.no/eksamensordning/privatist/25)
* [http://beta-psi.udir.no/eksamensordning/privatist/26](http://beta-psi.udir.no/eksamensordning/privatist/26)
* [http://beta-psi.udir.no/eksamensordning/elev/skriftlig\_eller\_praktisk](http://beta-psi.udir.no/eksamensordning/elev/skriftlig_eller_praktisk)

Det vil si at PSI-ene [http://beta-psi.udir.no/ontologi/eksamensordning\_elev](http://beta-psi.udir.no/ontologi/eksamensordning_elev) og  [http://beta-psi.udir.no/ontologi/eksamensordning\_privatist](http://beta-psi.udir.no/ontologi/eksamensordning_privatist) erstattes av nye verdier av typen [http://beta-psi.udir.no/ontologi/kl06/eksamensordning](http://beta-psi.udir.no/ontologi/kl06/eksamensordning). Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI | Tittel | Ny PSI |
| --- | --- | --- |
| [http://beta-psi.udir.no/eksamensordning/elev/4](http://beta-psi.udir.no/eksamensordning/elev/4) | Ingen eksamen | [http://beta-psi.udir.no/kl06/eksamensordning\_1](http://beta-psi.udir.no/kl06/eksamensordning_1) |
| [http://beta-psi.udir.no/eksamensordning/elev/10](http://beta-psi.udir.no/eksamensordning/elev/10) | Muntlig og praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_2](http://beta-psi.udir.no/kl06/eksamensordning_2) |
| [http://beta-psi.udir.no/eksamensordning/elev/11](http://beta-psi.udir.no/eksamensordning/elev/11) [http://beta-psi.udir.no/eksamensordning/privatist/7](http://beta-psi.udir.no/eksamensordning/privatist/7) | Muntlig-praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_3](http://beta-psi.udir.no/kl06/eksamensordning_3) |
| [http://beta-psi.udir.no/eksamensordning/elev/13](http://beta-psi.udir.no/eksamensordning/elev/13) [http://beta-psi.udir.no/eksamensordning/privatist/9](http://beta-psi.udir.no/eksamensordning/privatist/9) | Praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_4](http://beta-psi.udir.no/kl06/eksamensordning_4) |
| [http://beta-psi.udir.no/eksamensordning/elev/19](http://beta-psi.udir.no/eksamensordning/elev/19) [http://beta-psi.udir.no/eksamensordning/privatist/13](http://beta-psi.udir.no/eksamensordning/privatist/13) | Skriftlig | [http://beta-psi.udir.no/kl06/eksamensordning\_5](http://beta-psi.udir.no/kl06/eksamensordning_5) |
| [http://beta-psi.udir.no/eksamensordning/elev/20](http://beta-psi.udir.no/eksamensordning/elev/20) | Skriftlig eller muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_6](http://beta-psi.udir.no/kl06/eksamensordning_6) |
| [http://beta-psi.udir.no/eksamensordning/elev/21](http://beta-psi.udir.no/eksamensordning/elev/21) | Skriftlig eller muntlig-praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_7](http://beta-psi.udir.no/kl06/eksamensordning_7) |
| [http://beta-psi.udir.no/eksamensordning/elev/27](http://beta-psi.udir.no/eksamensordning/elev/27) | Skriftlig og/eller muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_8](http://beta-psi.udir.no/kl06/eksamensordning_8) |
| [http://beta-psi.udir.no/eksamensordning/elev/37](http://beta-psi.udir.no/eksamensordning/elev/37) | Skriftlig + ev. muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_9](http://beta-psi.udir.no/kl06/eksamensordning_9) |
| [http://beta-psi.udir.no/eksamensordning/elev/38](http://beta-psi.udir.no/eksamensordning/elev/38) | Hovedmål + ev. sidemål + ev. muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_10](http://beta-psi.udir.no/kl06/eksamensordning_10) |
| [http://beta-psi.udir.no/eksamensordning/elev/39](http://beta-psi.udir.no/eksamensordning/elev/39) | Tverrfaglig praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_11](http://beta-psi.udir.no/kl06/eksamensordning_11) |
| [http://beta-psi.udir.no/eksamensordning/elev/40](http://beta-psi.udir.no/eksamensordning/elev/40) | Tverrfaglig skriftlig | [http://beta-psi.udir.no/kl06/eksamensordning\_12](http://beta-psi.udir.no/kl06/eksamensordning_12) |
| [http://beta-psi.udir.no/eksamensordning/elev/7](http://beta-psi.udir.no/eksamensordning/elev/7) [http://beta-psi.udir.no/eksamensordning/privatist/4](http://beta-psi.udir.no/eksamensordning/privatist/4) | Muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_13](http://beta-psi.udir.no/kl06/eksamensordning_13) |
| [http://beta-psi.udir.no/eksamensordning/elev/fagproeve](http://beta-psi.udir.no/eksamensordning/elev/fagproeve) | Fagprøve | [http://beta-psi.udir.no/kl06/eksamensordning\_14](http://beta-psi.udir.no/kl06/eksamensordning_14) |
| [http://beta-psi.udir.no/eksamensordning/elev/fagproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/elev/fagproeve_skriftlig) [http://beta-psi.udir.no/eksamensordning/privatist/fagproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/privatist/fagproeve_skriftlig) | Fagprøve + skriftlig | [http://beta-psi.udir.no/kl06/eksamensordning\_15](http://beta-psi.udir.no/kl06/eksamensordning_15) |
| [http://beta-psi.udir.no/eksamensordning/elev/skriftlig\_muntlig](http://beta-psi.udir.no/eksamensordning/elev/skriftlig_muntlig)    [http://beta-psi.udir.no/eksamensordning/privatist/skriftlig\_muntlig](http://beta-psi.udir.no/eksamensordning/privatist/skriftlig_muntlig) | Skriftlig-muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_16](http://beta-psi.udir.no/kl06/eksamensordning_16) |
| [http://beta-psi.udir.no/eksamensordning/elev/svenneproeve](http://beta-psi.udir.no/eksamensordning/elev/svenneproeve) | Svenneprøve | [http://beta-psi.udir.no/kl06/eksamensordning\_17](http://beta-psi.udir.no/kl06/eksamensordning_17) |
| [http://beta-psi.udir.no/eksamensordning/elev/svenneproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/elev/svenneproeve_skriftlig) [http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve\_skriftlig](http://beta-psi.udir.no/eksamensordning/privatist/svenneproeve_skriftlig) | Svenneprøve + skriftlig | [http://beta-psi.udir.no/kl06/eksamensordning\_18](http://beta-psi.udir.no/kl06/eksamensordning_18) |
| [http://beta-psi.udir.no/eksamensordning/privatist/17](http://beta-psi.udir.no/eksamensordning/privatist/17) | Skriftlig og muntlig | [http://beta-psi.udir.no/kl06/eksamensordning\_19](http://beta-psi.udir.no/kl06/eksamensordning_19) |
| [http://beta-psi.udir.no/eksamensordning/privatist/19](http://beta-psi.udir.no/eksamensordning/privatist/19) | Skriftlig og muntlig-praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_20](http://beta-psi.udir.no/kl06/eksamensordning_20) |
| [http://beta-psi.udir.no/eksamensordning/privatist/2](http://beta-psi.udir.no/eksamensordning/privatist/2) | Hov.mål+Sid.mål sk+muntl | [http://beta-psi.udir.no/kl06/eksamensordning\_21](http://beta-psi.udir.no/kl06/eksamensordning_21) |
| [http://beta-psi.udir.no/eksamensordning/privatist/32](http://beta-psi.udir.no/eksamensordning/privatist/32) | Skriftlig og tverrfaglig praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_23](http://beta-psi.udir.no/kl06/eksamensordning_23) |
| [http://beta-psi.udir.no/eksamensordning/privatist/33](http://beta-psi.udir.no/eksamensordning/privatist/33) | Skriftlig og tverrfaglig | skriftlig    [http://beta-psi.udir.no/kl06/eksamensordning\_24](http://beta-psi.udir.no/kl06/eksamensordning_24) |
| [http://beta-psi.udir.no/eksamensordning/privatist/34](http://beta-psi.udir.no/eksamensordning/privatist/34) | Skriftlig og tverrfaglig muntlig-praktisk | [http://beta-psi.udir.no/kl06/eksamensordning\_25](http://beta-psi.udir.no/kl06/eksamensordning_25) |

Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.

### Eksamensform \(til bruk på dokumentasjon\)

Vi har gått gjennom verdier for eksamensform som kan benyttes på vitnemål og kompetansebevis, slik at disse er i tråd med forskrift til opplæringsloven. Kun verdier som kan benyttes i Kunnskapsløftet er videreført, og med ny psi/URI - den gamle kunne tolkes som at verdien kun gjaldt vitnemål og ikke all dokumentasjon.

Eksamensformer **som videreføres med ny PSI** er vist i tabellen under.

| Gammel PSI | Tittel | Ny PSI |
| --- | --- | --- |
| psi.udir.no/eksamensform/vitnemaal/ingen | Ingen eksamen | _psi.udir.no/kl06/eksamensform\_1_ |
| psi.udir.no/eksamensform/vitnemaal/skriftlig | Skriftlig | psi.udir.no/kl06/eksamensform\_2 |
| psi.udir.no/eksamensform/vitnemaal/muntlig | Muntlig | psi.udir.no/kl06/eksamensform\_3 |
| [psi.udir.no/eksamensform/vitnemaal/praktisk](http://psi.udir.no/eksamensform/vitnemaal/praktisk) | Praktisk | psi.udir.no/kl06/eksamensform\_4 |
| [psi.udir.no/eksamensform/vitnemaal/muntlig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_praktisk) | Muntlig-praktisk | psi.udir.no/kl06/eksamensform\_5 |
| [psi.udir.no/eksamensform/vitnemaal/fagproeve](http://psi.udir.no/eksamensform/vitnemaal/fagproeve) | Fagprøve | psi.udir.no/kl06/eksamensform\_6 |
| [psi.udir.no/eksamensform/vitnemaal/svenneproeve](http://psi.udir.no/eksamensform/vitnemaal/svenneproeve) | Svenneprøve | psi.udir.no/kl06/eksamensform\_7 |
| [psi.udir.no/eksamensform/vitnemaal/skriftlig\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_muntlig) | Skriftlig-muntlig | psi.udir.no/kl06/eksamensform\_8 |

Eksamensformer fra tidligere reformer **som ikke lenger benyttes** er vist i tabellen under. Disse eksamensformene kan ikke benyttes på dokumentasjon av fag i Kunnskapsløftet.

| Gammel PSI | Tittel |
| :--- | :--- |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_eller_muntlig_og_praktisk) | Muntlig eller muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_eller\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_eller_praktisk) | Muntlig eller praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_og_praktisk) | Muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_muntlig) | Skriftlig eller muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_muntlig_og_praktisk) | Skriftlig eller muntlig-praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_skriftlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_skriftlig_og_praktisk) | Skriftlig eller skriftlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_tegnspraaklig) | Skriftlig eller tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_muntlig) | Skriftlig og muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_muntlig\_eller\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_muntlig_eller_muntlig) | Skriftlig og muntlig eller muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_muntlig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_muntlig_praktisk) | Skriftlig og muntlig-praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_praktisk) | Skriftlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_praktisk\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_praktisk_eller_muntlig_og_praktisk) | Skriftlig og praktisk eller muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_tegnspraaklig) | Skriftlig og tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/tegnspraaklig) | Tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/teoretisk\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/teoretisk_og_praktisk) | Teoretisk og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_muntlig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_muntlig_praktisk) | Tverrfaglig muntlig-praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_praktisk) | Tverrfaglig praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_skriftlig](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_skriftlig) | Tverrfaglig skriftlig |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_eller_muntlig_og_praktisk) | Muntlig eller muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_eller\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_eller_praktisk) | Muntlig eller praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/muntlig_og_praktisk) | Muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_muntlig) | Skriftlig eller muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_muntlig_og_praktisk) | Skriftlig eller muntlig-praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_skriftlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_skriftlig_og_praktisk) | Skriftlig eller skriftlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_eller\_tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_eller_tegnspraaklig) | Skriftlig eller tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_muntlig) | Skriftlig og muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_muntlig\_eller\_muntlig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_muntlig_eller_muntlig) | Skriftlig og muntlig eller muntlig |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_praktisk) | Skriftlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_praktisk\_eller\_muntlig\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_praktisk_eller_muntlig_og_praktisk) | Skriftlig og praktisk eller muntlig og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/skriftlig\_og\_tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/skriftlig_og_tegnspraaklig) | Skriftlig og tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/tegnspraaklig](http://psi.udir.no/eksamensform/vitnemaal/tegnspraaklig) | Tegnspråklig |
| [http://psi.udir.no/eksamensform/vitnemaal/teoretisk\_og\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/teoretisk_og_praktisk) | Teoretisk og praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_muntlig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_muntlig_praktisk) | Tverrfaglig muntlig-praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_praktisk](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_praktisk) | Tverrfaglig praktisk |
| [http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig\_skriftlig](http://psi.udir.no/eksamensform/vitnemaal/tverrfaglig_skriftlig) | Tverrfaglig skriftlig |

### Vurderingsform

Vurderingsform har endret navn til Vurderingsuttrykk. Denne endringen påvirker kun nye verdier som greptype og kode for eksisterende element.

