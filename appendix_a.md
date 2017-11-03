# Appendix A - Endringer i datagrunnlaget

## Hjelpedata

Det er gjort en del endringer i innholdet i hjelpedata i forbindelse med denne releasen. Alle hjelpedata har blitt merket med aktuell greptype, og har fått en unik kode. I denne prosessen ble det bestemt at Oppgave/Sensur skulle spittes opp i to hjepedatatyper. En for Oppgave og en for Sensur. I tillegg skulle hjelpedatatypene som var definert for spesifikke elevtype, elev eller privatist, gjøres om til en felles type som gjelde for alle elevtyper. Andre hjelpedatatyper ble omdøpt uten at eksisterende innhold ble endret eller at de ble erstattet av nye verdier.

### Oppgave/Sensur

Hjelpedatatypen Oppgave/Sensur utgår. Den erstattes av to nye typer, Oppgave og Sensur.  
Det samme vil gjelde for hjelpedataene av denne typen.

* Lokal
* Sentral

Det vil si at PSI _psi.udir.no/ontologi/oppgavesensur_ erstattes av

* _data.udir.no/psi/ontologi/kl06/oppgave_ i tilfellene der verdien gjelder oppgave.
  * Verdier for denne typen er:
    * _psi.udir.no/kl06/oppgave\_lokal_
    * _psi.udir.no/kl06/oppgave\_sentral_
* _data.udir.no/psi/ontologi/kl06/sensur_ i tilfelle verdien gjelder sensur
  * Verdier for denne typen er:
    * _psi.udir.no/kl06/sensur\_lokal_
    * _psi.udir.no/kl06/sensur\_sentral_

### Eksamensfag/Elev og Eksamensfag/Privatist

Eksamensfag/Elev og Eksamensfag/Privatist utgår. Disse erstattes av en ny type, Trekkordning  
Det samme vil gjelde for alle hjelpedatatene av disse typene:

* _psi.udir.no/eksamensfag/elev/6_
* _psi.udir.no/eksamensfag/elev/4_
* _psi.udir.no/eksamensfag/elev/3_
* _psi.udir.no/eksamensfag/elev/5_
* _psi.udir.no/eksamensfag/elev/10_
* _psi.udir.no/eksamensfag/elev/7_
* _psi.udir.no/eksamensfag/privatist/9_
* _psi.udir.no/eksamensfag/privatist/3_
* _psi.udir.no/eksamensfag/privatist/4_
* _psi.udir.no/eksamensfag/privatist/5_
* _psi.udir.no/eksamensfag/privatist/11_
* _psi.udir.no/eksamensfag/privatist/10_
* Det vil si at PSI-ene _psi.udir.no/ontologi/eksamensfag\_elev_ og  _psi.udir.no/ontologi/eksamensfag\_privatist_ erstattes av nye verdier av typen _data.udir.no/psi/ontologi/kl06/trekkordning_. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI | Tittel | Ny PSI |
| --- | --- | --- |
| _psi.udir.no/eksamensfag/elev/3_ _psi.udir.no/eksamensfag/privatist/3_ | Ingen eksamen | _psi.udir.no/kl06/trekkordning\_1_ |
| _psi.udir.no/eksamensfag/elev/7_ _psi.udir.no/eksamensfag/privatist/10_ | Trekkfag | _psi.udir.no/kl06/trekkordning\_2_ |
| _psi.udir.no/eksamensfag/elev/5_ _psi.udir.no/eksamensfag/privatist/4_ | Obligatorisk | _psi.udir.no/kl06/trekkordning\_3_ |

Hjelpedata av denne typen som ikke er med i mappingen er ikke lenger i bruk.

### Eksamensordning/Elev og Eksamensordning/Privatist

Hjelpedatatypene Eksamensordning Elev og Eksamensordning Privatist utgår. Disse erstattes av en ny type, Eksamensordning.

Det samme vil gjelde for alle hjelpedataene av disse to typene:

* _psi.udir.no/eksamensordning/elev/fagproeve_
* _psi.udir.no/eksamensordning/elev/fagproeve\_skriftlig_
* _psi.udir.no/eksamensordning/elev/2_
* _psi.udir.no/eksamensordning/elev/3_
* _psi.udir.no/eksamensordning/elev/38_
* _psi.udir.no/eksamensordning/elev/4_
* _psi.udir.no/eksamensordning/elev/5_
* _psi.udir.no/eksamensordning/elev/6_
* _psi.udir.no/eksamensordning/elev/33_
* _psi.udir.no/eksamensordning/elev/7_
* _psi.udir.no/eksamensordning/elev/8_
* _psi.udir.no/eksamensordning/elev/9_
* _psi.udir.no/eksamensordning/elev/10_
* _psi.udir.no/eksamensordning/elev/36_
* _psi.udir.no/eksamensordning/elev/12_
* _psi.udir.no/eksamensordning/elev/11_
* _psi.udir.no/eksamensordning/elev/13_
* _psi.udir.no/eksamensordning/elev/14_
* _psi.udir.no/eksamensordning/elev/15_
* _psi.udir.no/eksamensordning/elev/16_
* _psi.udir.no/eksamensordning/elev/17_
* _psi.udir.no/eksamensordning/elev/18_
* _psi.udir.no/eksamensordning/elev/34_
* _psi.udir.no/eksamensordning/elev/35_
* _psi.udir.no/eksamensordning/elev/26_
* _psi.udir.no/eksamensordning/elev/28_
* _psi.udir.no/eksamensordning/elev/32_
* _psi.udir.no/eksamensordning/elev/19_
* _psi.udir.no/eksamensordning/elev/37_
* _psi.udir.no/eksamensordning/elev/20_
* _psi.udir.no/eksamensordning/elev/21_
* _psi.udir.no/eksamensordning/elev/22_
* _psi.udir.no/eksamensordning/elev/23_
* _psi.udir.no/eksamensordning/elev/24_
* _psi.udir.no/eksamensordning/elev/25_
* _psi.udir.no/eksamensordning/elev/27_
* _psi.udir.no/eksamensordning/elev/29_
* _psi.udir.no/eksamensordning/elev/30_
* _psi.udir.no/eksamensordning/elev/31_
* _psi.udir.no/eksamensordning/elev/skriftlig\_muntlig_
* _psi.udir.no/eksamensordning/elev/svenneproeve_
* _psi.udir.no/eksamensordning/elev/svenneproeve\_skriftlig_
* _psi.udir.no/eksamensordning/elev/41_
* _psi.udir.no/eksamensordning/elev/39_
* _psi.udir.no/eksamensordning/elev/40_
* _psi.udir.no/eksamensordning/privatist/3_
* _psi.udir.no/eksamensordning/privatist/1_
* _psi.udir.no/eksamensordning/privatist/fagproeve_
* _psi.udir.no/eksamensordning/privatist/fagproeve\_skriftlig_
* _psi.udir.no/eksamensordning/privatist/2_
* _psi.udir.no/eksamensordning/privatist/28_
* _psi.udir.no/eksamensordning/privatist/5_
* _psi.udir.no/eksamensordning/privatist/4_
* _psi.udir.no/eksamensordning/privatist/6_
* _psi.udir.no/eksamensordning/privatist/8_
* _psi.udir.no/eksamensordning/privatist/7_
* _psi.udir.no/eksamensordning/privatist/9_
* _psi.udir.no/eksamensordning/privatist/10_
* _psi.udir.no/eksamensordning/privatist/11_
* _psi.udir.no/eksamensordning/privatist/12_
* _psi.udir.no/eksamensordning/privatist/31_
* _psi.udir.no/eksamensordning/privatist/21_
* _psi.udir.no/eksamensordning/privatist/23_
* _psi.udir.no/eksamensordning/privatist/27_
* _psi.udir.no/eksamensordning/privatist/16_
* _psi.udir.no/eksamensordning/privatist/18_
* _psi.udir.no/eksamensordning/privatist/13_
* _psi.udir.no/eksamensordning/privatist/15_
* _psi.udir.no/eksamensordning/privatist/14_
* _psi.udir.no/eksamensordning/privatist/29_
* _psi.udir.no/eksamensordning/privatist/17_
* _psi.udir.no/eksamensordning/privatist/19_
* _psi.udir.no/eksamensordning/privatist/20_
* _psi.udir.no/eksamensordning/privatist/34_
* _psi.udir.no/eksamensordning/privatist/32_
* _psi.udir.no/eksamensordning/privatist/33_
* _psi.udir.no/eksamensordning/privatist/22_
* _psi.udir.no/eksamensordning/privatist/24_
* _psi.udir.no/eksamensordning/privatist/skriftlig\_muntlig_
* _psi.udir.no/eksamensordning/privatist/svenneproeve_
* _psi.udir.no/eksamensordning/privatist/svenneproeve\_skriftlig_
* _psi.udir.no/eksamensordning/privatist/30_
* _psi.udir.no/eksamensordning/privatist/25_
* _psi.udir.no/eksamensordning/privatist/26_
* _psi.udir.no/eksamensordning/elev/skriftlig\_eller\_praktisk_

Det vil si at PSI-ene _psi.udir.no/ontologi/eksamensordning\_elev_ og  _psi.udir.no/ontologi/eksamensordning\_privatist_ erstattes av nye verdier av typen _data.udir.no/psi/ontologi/kl06/eksamensordning_. Mapping som viser hvilken ny verdi som ersatter den gamle ligger i tabellen under.

| Gammel PSI | Tittel | Ny PSI |
| --- | --- | --- |
| _psi.udir.no/eksamensordning/elev/4_ | Ingen eksamen | _psi.udir.no/kl06/eksamensordning\_1_ |
| _psi.udir.no/eksamensordning/elev/10_ | Muntlig og praktisk | _psi.udir.no/kl06/eksamensordning\_2_ |
| _psi.udir.no/eksamensordning/elev/11_ _psi.udir.no/eksamensordning/privatist/7_ | Muntlig-praktisk | _psi.udir.no/kl06/eksamensordning\_3_ |
| _psi.udir.no/eksamensordning/elev/13_ _psi.udir.no/eksamensordning/privatist/9_ | Praktisk | _psi.udir.no/kl06/eksamensordning\_4_ |
| _psi.udir.no/eksamensordning/elev/19_ _psi.udir.no/eksamensordning/privatist/13_ | Skriftlig | _psi.udir.no/kl06/eksamensordning\_5_ |
| _psi.udir.no/eksamensordning/elev/20_ | Skriftlig eller muntlig | _psi.udir.no/kl06/eksamensordning\_6_ |
| _psi.udir.no/eksamensordning/elev/21_ | Skriftlig eller muntlig-praktisk | _psi.udir.no/kl06/eksamensordning\_7_ |
| _psi.udir.no/eksamensordning/elev/27_ | Skriftlig og/eller muntlig | _psi.udir.no/kl06/eksamensordning\_8_ |
| _psi.udir.no/eksamensordning/elev/37_ | Skriftlig + ev. muntlig | _psi.udir.no/kl06/eksamensordning\_9_ |
| _psi.udir.no/eksamensordning/elev/38_ | Hovedmål + ev. sidemål + ev. muntlig | _psi.udir.no/kl06/eksamensordning\_10_ |
| _psi.udir.no/eksamensordning/elev/39_ | Tverrfaglig praktisk | _psi.udir.no/kl06/eksamensordning\_11_ |
| _psi.udir.no/eksamensordning/elev/40_ | Tverrfaglig skriftlig | _psi.udir.no/kl06/eksamensordning\_12_ |
| _psi.udir.no/eksamensordning/elev/7_ _psi.udir.no/eksamensordning/privatist/4_ | Muntlig | _psi.udir.no/kl06/eksamensordning\_13_ |
| _psi.udir.no/eksamensordning/elev/fagproeve_ | Fagprøve | _psi.udir.no/kl06/eksamensordning\_14_ |
| _psi.udir.no/eksamensordning/elev/fagproeve\_skriftlig_ _psi.udir.no/eksamensordning/privatist/fagproeve\_skriftlig_ | Fagprøve + skriftlig | _psi.udir.no/kl06/eksamensordning\_15_ |
| _psi.udir.no/eksamensordning/elev/skriftlig\_muntlig_    _psi.udir.no/eksamensordning/privatist/skriftlig\_muntlig_ | Skriftlig-muntlig | _psi.udir.no/kl06/eksamensordning\_16_ |
| _psi.udir.no/eksamensordning/elev/svenneproeve_ | Svenneprøve | _psi.udir.no/kl06/eksamensordning\_17_ |
| _psi.udir.no/eksamensordning/elev/svenneproeve\_skriftlig_ _psi.udir.no/eksamensordning/privatist/svenneproeve\_skriftlig_ | Svenneprøve + skriftlig | _psi.udir.no/kl06/eksamensordning\_18_ |
| _psi.udir.no/eksamensordning/privatist/17_ | Skriftlig og muntlig | _psi.udir.no/kl06/eksamensordning\_19_ |
| _psi.udir.no/eksamensordning/privatist/19_ | Skriftlig og muntlig-praktisk | _psi.udir.no/kl06/eksamensordning\_20_ |
| _psi.udir.no/eksamensordning/privatist/2_ | Hov.mål+Sid.mål sk+muntl | _psi.udir.no/kl06/eksamensordning\_21_ |
| _psi.udir.no/eksamensordning/privatist/32_ | Skriftlig og tverrfaglig praktisk | _psi.udir.no/kl06/eksamensordning\_23_ |
| _psi.udir.no/eksamensordning/privatist/33_ | Skriftlig og tverrfaglig | skriftlig    _psi.udir.no/kl06/eksamensordning\_24_ |
| _psi.udir.no/eksamensordning/privatist/34_ | Skriftlig og tverrfaglig muntlig-praktisk | _psi.udir.no/kl06/eksamensordning\_25_ |

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

Eksamensformer fra tidligere reformer **som ikke lenger benyttes** er vist i tabellen under. Disse eksamensformene kan ikke benyttes for fag i Kunnskapsløftet.

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

