# SOAP-grensesnittet {#soap-grensesnittet}

Grep tilbyr også et SOAP-grensesnitt. URL for endepunktet for dette grensesnittet er [http://beta-data.udir.no/kl06/soap](http://beta-data.udir.no/kl06/soap). Det ligger en online dokumentasjon av soap-endepunktet på denne adressen ved direkte oppslag. Wsdl/kontrakten for denne tjenesten kan hentes ut på følgende URL'er: [http://beta-data.udir.no/kl06/soap?wsdl&version=v201604](http://beta-data.udir.no/kl06/soap?wsdl&version=v201604) og [http://beta-data.udir.no/kl06/soap?wsdl&version=v201802](http://beta-data.udir.no/kl06/soap?wsdl&version=v201802). Kontraktene inneholder tjenestekontrakten og alle relevante datatyper.

Tilgjengelige versjoner:

* [201604](http://beta-data.udir.no/kl06/soap?wsdl&version=v201604)
* [201802](http://beta-data.udir.no/kl06/soap?wsdl&version=v201802)

[http://beta-data.udir.no/kl06/soap?wsdl](http://beta-data.udir.no/kl06/soap?wsdl) peker på versjon 201604.

Det er nå også mulig å adressere versjonene ved å legge inn versjonsnummer i url'en. Henholdsvis [http://beta-data.udir.no/kl06/v201604/soap?wsd](http://beta-data.udir.no/kl06/v201604/soap?wsdl)l og [http://beta-data.udir.no/kl06/v201802/soap?wsdl](http://beta-data.udir.no/kl06/v201802/soap?wsdl).

SOAP-grensesnittet tilbyr følgende metoder for å finne og hente informasjon fra Grep versjon 201604.

| **Metode** | **Beskrivelse** | **Teknisk dokumentasjon** |
| --- | --- | --- |
| FinnPlaner | Finner læreplaner basert på søkekriterier. Se teknisk dokumentasjon for detaljer rundt parametere | [SOAP-grensesnit](http://beta-data.udir.no/kl06/soap)t |
| FinnFagkoder | Finner fagkoder basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnProgramomraader | Finner programområder basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnUtdanningsprogram | Finner utdanningsprogram basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnMerknader | Finner merknader basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnMerkelapper | Finner merkelapper basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnFagomraader | Finner fagområder basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnFagkategorier | Finner fagkategorier basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnKompetansemaal | Finner kompetansemål basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnOpplaeringsfag | Finner opplæringsfag basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnAarstrinn | Finner årstrinn basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnStatus | Finner status basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnSpraak | Finner språk basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnFagtype | Finner fagtype basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnOpplaeringsnivaa | Finner opplæringsnivå basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnKompetansemaalsett | Finner kompetansemålsett basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnProgramfag | Finner programfag basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnHovedomraade | Finner hovedområde basert på søkekriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| FinnKarakterer | Finner karakterer basert på søkeriterier. Se teknisk dokumentasjon for detaljer | [SOAP-grensesnitt](http:\\beta-data.udir.no\kl06\soap) |
| HentPlanFraKode | Returnerer en læreplan basert på læreplanens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentPlanFraPsi | Returnerer en læreplan basert på læreplanens PSI \(id\) | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagkodeFraKode | Returnerer en fagkode basert på fagets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagkodeFraPsi | Returnerer en fagkode basert på fagets PSI \(id\) | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentProgramomraadeFraKode | Returnerer et programområde basert på programområdets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentProgramomraadeFraPsi | Returnerer et programområde basert på programområdets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentUtdanningsprogramFraKode | Returnerer et utdanningsprogram basert på utdanningsprogrammets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentUtdanningsprogramFraPsi | Returnerer et utdanningsprogram basert på PSI \(id\) | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentMerknadFraPsi | Returnerer en merknad basert på merknadens psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentMerknadFraKode | Returnerer en merknad basert på merknadens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentMerkelapperFraPsi | Returnerer en merkelapp basert på merkelappens psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentMerkelapperFraKode | Returnerer en merkelapp basert på merkelappens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentKompetansemaalFraPsi | Returnerer et kompetansemål basert på kompetansemålets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentKompetansemaalFraKode | Returnerer et kompetansemål basert på kompetansemålets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagomraadeFraPsi | Returnerer et fagområde basert på kompetansemålets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagomraadeFraKode | Returnerer et fagområde basert på kompetansemålets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagkategoriFraPsi | Returnerer en fagkategori basert på kompetansemålets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagkategoriFraKode | Returnerer en fagkategori basert på kompetansemålets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentOpplaeringsfagFraPsi | Returnerer et opplæringsfag basert på opplæringsfagets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentOpplaeringsfagFraKode | Returnerer et opplæringsfag basert på opplæringsfagets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentAarstrinmFraPsi | Returnerer et årstrinn basert på årstrinnets psi | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentStatusFraKode | Returnerer en status basert på statusens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentSpraakFraKode | Returnerer et språk basert på språkets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentFagtypeFraKode | Returnerer en fagtype basert på fagtypens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentOpplaeringsnivaaFraKode | Returnerer et opplæringsnivå basert på opplæringsnivåets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentKompetansemaalsettFraKode | Returnerer et kompetansemålsett basert på kompetansemålsettets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentProgramfagFraKode | Returnerer et programfag basert på programfagets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentHovedomraadeFraKode | Returnerer et hovedområde basert på hovedområdets kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |
| HentKarakterFraKode | Returnerer en klarakter basert på karakterens kode | [SOAP-grensesnitt](http://beta-data.udir.no/kl06/soap) |



