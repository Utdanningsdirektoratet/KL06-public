# Ofte stilte spørsmål
<a id="maxmessage" href="#"></a>
### Feilmelding med "maximum message size exceeded"?
Om man benytter .NET og KL06s SOAP-endepunkt, så vil man med standardinnstillinger få denne feilmeldingen ved blant annet nedhenting av liste over alle læreplaner. Dette er klientinnstillinger og ikke noe vi kan styre fra KL06.

Løsning på dette er å øke maks størrelse på returmeldinger. I samme slengen kan man øke maks antall elementer returnert i en liste. Gå til konfigurasjonsfila for applikasjonen (typ app.config eller web.config). Endre bindingen til kl06 til dette

[import:9-13,lang-xml](eksempler/kildekode/csharp/Kl06.Eksempler/App.config)


<a id="traversere" href="#"></a>
### Må jeg traverse hele KL06 for å hente ned alle data?
Inntil videre - ja. De fleste har dog ikke behov for alle data.

