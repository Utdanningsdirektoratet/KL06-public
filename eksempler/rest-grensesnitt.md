## REST-grensesnitt {#rest-grensesnitt}

### Utlisting av alle fagkoder i html-side med JQuery {#utlisting-av-alle-fagkoder-i-html-side-med-jquery}

Følgende html-dokument benytter JQuery og REST-grensesnittet for å liste ut en enkel html-side med lenker til alle fagkoder. Lenkene peker på URL-data – URLen, med kode og tittel som beskrivelse av lenken:

Test.html:

{%ace edit=false, check=false, lang='xml'%}
<!DOCTYPE html>
<html>
  <head>
    <title>Test</title>
    <meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>
    <script src="http://code.jquery.com/jquery-latest.js">
    </script>
  </head>
  <body>
    <p></p>
    <script type="text/jscript">
    $.getJSON("http://beta-data.udir.no/kl06/fagkoder", {},
      function (data)
      {
        $.each(data, function (i, fagkoder) {$('p').append('<a href=' + fagkoder["url-data"] + '>' + fagkoder.kode + ' - ' + fagkoder.tittel + '&lt;/a&gt;&lt;br&gt;'); 
      })
    });
    </script>
  </body>
</html>
{%endace%}

Html-side i nettleser:

### Kombinasjon av grensesnitt (REST og OData) {#kombinasjon-av-grensesnitt-rest-og-odata}

Som et eksempel på litt mer avansert bruk, demonstrerer vi her et eksempel som tilbyr et “fritekst”-søk etter læreplaner, og mulighet for å se på detaljert informasjon om læreplanen (formålet med læreplanen). Eksempelet tar i bruk JQuery og jQuery-ui (og sannsynligvis ganske amatørmessig utført), men kan like gjerne utføres i andre teknologier.

På bildet under ser du et bilde hvor du kan skrive inn deler av kode eller tittel, og får tilbake en liste med treff. Søket går mot OData-grensesnittet, hvor du har stor frihet til å definere hva du vil hente ut, og hvordan. I dette eksempelet vil du hente tilbake kode, tittel og URL-data-feltene fra de læreplanene (maks 25) hvor læreplanens sammenslåtte kode og tittel inneholder deler av søkestrengen.

Metoden for å søke ser slik ut:

{%ace edit=false, check=false%}
// Søker etter læreplaner
function soekEtterLaereplaner(soekestreng, maksAntallTreff) {
  var url = baseurl + "odata/Læreplan?$format=json";
  var filter = "&$filter=substringof('" + soekestreng.toLowerCase() + "', tolower(concat(concat(Kode, ' - '), Tittel))) eq true";
  var maksResultatFilter = "&$top=" + maksAntallTreff;
  var selekterFilter = "&$select=Tittel,Kode,UrlData";
  $.ajax({
    type: "GET",
    url: url + filter + maksResultatFilter + selekterFilter,
    success: function (msg) {
    // behandler resultatet
    }
  });
}
{%endace%}

Denne benytter standard OData-funksjonalitet for å oppgi filter og hva den vil ha tilbake. I en søke-intensiv applikasjon vil dette spare ressurser og båndbredde for klient-applikasjon og webserveren.

Ved å klikke på ett av treffene, vil den detaljerte læreplanen hentes, og formål vises:

Fra søkeresultatet har vi både URL-data-feltet, og kode-feltet. Begge disse kan brukes for å hente ut detaljer om læreplanen. Vi er kun interessert i å vise formål, og vi velger å vise formål på “default”-språket, som vil tilsvare fastsatt språk på læreplanen:

{%ace edit=false, check=false,  lang='xml'%}
// Utdrag av koden for å hente ut detaljert læreplan, og vise formål på default språk
$.getJSON(baseurl + "kl06/" + lp.Kode, function (f) {
  $('#f' + f.kode).append('&lt;p&gt;' + hentDefaultVerdi(f.formaal) + '&lt;/p&gt;');
});
// Henter ut den språkversjonerte verdien med nøkkelen 'default'
function hentDefaultVerdi(spraakversjonert) {
  var res = "";
  $.each(spraakversjonert, function (i, s) {
    if (s.noekkel = "default")
    res = s.verdi;
  });
  return res;
}
{%endace%}

**Komplett kode til dette eksempelet (krever jquery-ui med “accordion”-widget)**

{%ace edit=false, check=false, lang='xml'%}
<!DOCTYPE html>
<html>
  <head>
    <title>Læreplansøk</title>
    <meta http-equiv='Content-Type' content='text/html;charset=UTF-8'/>
    <link type="text/css" href="css/ui-lightness/jquery-ui-1.8.14.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jquery-1.5.1.min.js"></script>
    <script src="js/jquery-ui-1.8.14.custom.min.js" type="text/javascript"></script>
  </head>
  <body>
    <script type="text/javascript">
      var baseurl = "http://beta-data.udir.no/";
      var maksAntallTreff = 25;
      // Hekter på event på søke-input til å kalle soekEtterLaereplaner, med søkestreng og maks 25 antall treff
      $(document).ready(function () {
        $('input[name=soek]').keyup(function () { soekEtterLaereplaner($('input[name=soek]').val(), maksAntallTreff); }
        );
      });
      // Søker etter læreplaner, kaller lastInnResultater
      function soekEtterLaereplaner(soekestreng, maksAntallTreff) {
        var url = baseurl + "odata/Læreplan?$format=json";
        var filter = "&$filter=substringof('" + soekestreng.toLowerCase() + "', tolower(concat(concat(Kode, ' - '), Tittel))) eq true";
        var maksResultatFilter = "&$top=" + maksAntallTreff;
        var selekterFilter = "&$select=Tittel,Kode,UrlData";
        $.ajax({
          type: "GET",
          url: url + filter + maksResultatFilter + selekterFilter,
          success: function (msg) {
            $("#resultat").accordion('destroy');
            $("#resultat").text('');
            lastInnResultater(msg.d.results);
            $("#resultat").accordion({ header: "h3", autoHeight: false, collapsible: true, active: false, height: 180 });
          }
        });
      }
      // Lister ut resultatene, og hekter på et event som gjør at formål hentes fra detaljert informasjon om læreplan når resultatet åpnes
      function lastInnResultater(results) {
        $.each(results, function (i, lp) {
          $('#resultat').append("<div id=" + lp.Kode + '><h3><a href="#">' + lp.Kode + " - " + lp.Tittel + '</a></h3><div style="height:300px" id=f' + lp.Kode + '><b>Formål</b></div></div>');
          $("#" + lp.Kode).live("click", 
          function () {
            $.getJSON(baseurl + "kl06/" + lp.Kode,
            function (f) {
              $('#f' + f.kode).append('<p>' + hentDefaultVerdi(f.formaal) + '</p>');
              });
          });
        });
      }
      // Henter ut den språkversjonerte verdien med nøkkelen 'default'
      function hentDefaultVerdi(spraakversjonert) {
        var res = "";
        $.each(spraakversjonert, function (i, s) {
          if (s.noekkel = "default")
          res = s.verdi;
        });
        return res;
      }
    </script>
    <p style="font-family: Arial, Sans-Serif; font-size: 15px; margin-bottom: 5px; display: block; padding: 4px; border: solid 1px #85b1de; background-color: #EDF2F7;">
    Søk på læreplaner: 
      <input style="width: 300px;" id="soek" name="soek" type="text"/>
    </p>
    <div id="resultat"></div>
  </body>
</html>
{%endace%}
