# Appendix B - Endringer i SOAP-kontrakten

Endringer i datagrunnlag knyttet til tidligere versjoner er tilgjengelig [her](https://kl06-doc.gitbooks.io/kl06-public/content/appendix_b.html).

## Oppsummering av endringer som medfører nytt versjonsnummer
####Parametere som har blitt fjernet
- nasjonalvariant i metoden Respons fra metode - HentProgramomraadeFraKode: programomraade.nasjonalvariant
- nasjonalvariant i metoden Respons fra metode HentProgramomraadeFraPsi: programomraade.nasjonalvariant
- greptype i metoden FinnSpraak input: hjelpedatasoekrequest.greptype
- greptype i metoden FinnStatus input: hjelpedatasoekrequest.greptype
- greptype i metoden FinnOpplaeringsnivaa input: hjelpedatasoekrequest.greptype
- greptype i metoden FinnFagtype input: hjelpedatasoekrequest.greptype

####Parametere som har endret type
Parameter merkelapper har endret type fra basereferanse[] til referansemedgyldighet[]

Dette gjelder på følgende steder

- Respons fra metode HentPlanFraKode: laereplan
- Respons fra metode HentPlanFraPsi: laereplan
- Respons fra metode HentFagkodeFraKode: fagkode
- Respons fra metode HentFagkodeFraPsi: fagkode
- Respons fra metode HentOpplaeringsfagFraKode: opplaeringsfag
- Respons fra metode HentOpplaeringsfagFraPsi: opplaeringsfag
- Respons fra metode HentProgramomraadeFraKode: programomraade
- Respons fra metode HentProgramomraadeFraPsi: programomraade

---
Parameter eksamensformpaavitnemaalet har endret type fra hjelpedataverdi til basereferanse

Dette gjelder på følgende steder

- Respons fra metode HentFagkodeFraKode: fagkode.vurderingsordning
- Respons fra metode HentFagkodeFraPsi: fagkode.vurderingsordning

---
Parameter trekkordning har endret type fra hjelpedataverdi til basereferanse

Dette gjelder på følgende steder

- Respons fra metode HentFagkodeFraKode: fagkode.vurderingsordning
- Respons fra metode HentFagkodeFraPsi: fagkode.vurderingsordning

---
Parameter typeeksamensordning har endret type fra hjelpedataverdi til basereferanse

Dette gjelder på følgende steder

- Respons fra metode HentFagkodeFraKode: fagkode.vurderingsordning
- Respons fra metode HentFagkodeFraPsi: fagkode.vurderingsordning

---
Parameter vurderingsuttrykk har endret type fra hjelpedataverdi til basereferanse

Dette gjelder på følgende steder

- Respons fra metode HentFagkodeFraKode: fagkode.vurderingsordning
- Respons fra metode HentFagkodeFraPsi: fagkode.vurderingsordning

---
Parameter tilknyttedefag har endret type fra referanse[] til referansemedgyldighet[]

Dette gjelder på følgende steder

- Respons fra metode HentMerkelappFraKode: merkelapp
- Respons fra metode HentMerkelappFraPsi: merkelapp

---
Parameter tilknyttedelaereplaner har endret type fra referanse[] til referansemedgyldighet[]

Dette gjelder på følgende steder

- Respons fra metode HentMerkelappFraKode: merkelapp
- Respons fra metode HentMerkelappFraPsi: merkelapp

---
Parameter tilknyttedeprogramomraader har endret type fra referanse[] til referansemedgyldighet[]

Dette gjelder på følgende steder

- Respons fra metode HentMerkelappFraKode: merkelapp
- Respons fra metode HentMerkelappFraPsi: merkelapp

---
Parameter treff har endret type fra aarstrinn[] til aarstrinnsoekeresultat[]

Parameter Respons fra metode FinnAarstrinn: aarstrinnsøkrespons.treff har endret type fra aarstrinn[] til aarstrinnsoekeresultat[]

---
Parameter treff har endret type fra hjelpedatasoekeresultat[] til spraaksoekeresultat[]

Parameter Respons fra metode FinnSpraak: spraaksoekrespons.treff har endret type fra hjelpedatasoekeresultat[] til spraaksoekeresultat[]

---
Parameter treff har endret type fra hjelpedatasoekeresultat[] til statussoekeresultat[]

Parameter Respons fra metode FinnStatus: statussoekrespons.treff har endret type fra hjelpedatasoekeresultat[] til statussoekeresultat[]

---
Parameter treff har endret type fra hjelpedatasoekeresultat[] til opplaeringsnivaasoekeresultat[]

Parameter Respons fra metode FinnOpplaeringsnivaa: opplaeringsnivaasoekrespons.treff har endret type fra hjelpedatasoekeresultat[] til opplaeringsnivaasoekeresultat[]

---
Parameter treff har endret type fra hjelpedatasoekeresultat[] til fagtypesoekeresultat[]

Parameter Respons fra metode FinnFagtype: fagtypesoekrespons.treff har endret type fra hjelpedatasoekeresultat[] til fagtypesoekeresultat[]

---
##Oppsummering av endringer som ikke bryter kontrakten
####Metoder som har blitt lagt til
- FinnEksamensformer
- HentEksamensformFraKode
- FinnEksamensordninger
- HentEksamensordningFraKode
- FinnTrekkordninger
- HentTrekkordningFraKode
- FinnVurderingsuttrykk
- HentVurderingsuttrykkFraKode

####Parametere som har blitt lagt til
- id av typen String i metoden Respons fra metode HentSpraakFraKode: språk.id
- id av typen String i metoden Respons fra metode HentStatusFraKode: status.id
- id av typen String i metoden Respons fra metode HentOpplaeringsnivaaFraKode: opplaeringsnivaa.id
- id av typen String i metoden Respons fra metode HentFagtypeFraKode: fagtype.id
- opplaeringsnivaa av typen basereferanse i metoden Respons fra metode HentFagtypeFraKode: fagtype.opplaeringsnivaa
- kortform av typen spraakversjonert[] i metoden Respons fra metode HentFagtypeFraKode: fagtype.kortform

---
