# Filter på tidspunkt {#filter-på-tidspunt}

Når en henter ut et element i rest-grensesnittet (kl06/kode) vil alle relasjoner for dette elemetet vises. Det vil si at utgåtte, aktive og koblinger for fremtiden er med i listene. Dersom en ønsker å hente ut gyldig informasjon for et bestemt tidpunkt kan en benytte filteret ?tidspunkt = "angitt tidspunt".

Eksempel:
http://data.udir.no/kl06/NOR0214?tidspunkt=2016-06-01T00:00:00

Denne filtreringsmetoden kan benyttes på alle spørringer, også spesialspørringene som er beskrevet i kapitlet "Spesialspørringer".

Eksempel:
http://data.udir.no/kl06/mat0010/opplaeringsfag?Fagtype=fagtype_grunnskolefag&tidspunkt=2016-06-01T00:00:00