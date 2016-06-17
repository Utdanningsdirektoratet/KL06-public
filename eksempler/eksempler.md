# Eksempler {#eksempler}

Nå følger det to eksempler på hvordan REST- og SOAP-grensesnittet kan brukes i praksis.

*Test-eksempel 1: List alle properties for en gitt kode (NOR1-05).*
{%ace edit=false, check=false, lang='mysql'%}
SELECT *
WHERE {
<http://beta-data.udir.no/kl06/NOR1-05> ?p ?o
}
{%endace%}