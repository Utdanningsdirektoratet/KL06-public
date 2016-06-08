# Eksempler {#eksempler}

## Bruk av SOAP-grensesnitt (.Net) {#bruk-av-soap-grensesnitt-net}

Her følger et enkelt eksempel på hvordan du kan ta i bruk SOAP-grensesnittet i en .Net-basert applikasjon.

Figur 5: Opprett en ny applikasjon

Figur 6: Legg til en ny tjeneste-referanse

Figur 7: Oppgi URL (http://data.udir.no/KL06/soap), trykk "GO" og OK

### Endringer i konfigurasjon {#endringer-i-konfigurasjon}

I dette tilfellet benytter vi en WCF proxy-klasse for å få tilgang til tjenesten. Denne har en del standard innstillinger, som blant annet går på hvor mange elementer man kan laste ned, og størrelsen på “pakken” fra tjenesten. Grep-tjenesten kan i utgangspunktet gi en oversikt over alle læreplaner, og dette vil overstige standardinnstillingene. For å endre dette – gå til applikasjonens app.config. Der vil du finne noen linjer som ligner på disse:

[import](eksempler/kildekode/csharp/Kl06.Eksempler/App.config)

```xml
<basicHttpBinding>
  <binding name="GrepSoapBinding_GrepSoap" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:01:00" allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard" maxBufferSize="65536" maxBufferPoolSize="524288" maxReceivedMessageSize="65536" messageEncoding="Text" textEncoding="utf-8" transferMode="Buffered" useDefaultWebProxy="true">
    <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384" maxBytesPerRead="4096" maxNameTableCharCount="16384" />
    <security mode="None">
      <transport clientCredentialType="None" proxyCredentialType="None" realm="" />
      <message clientCredentialType="UserName" algorithmSuite="Default" />
    </security>
  </binding>
</basicHttpBinding>
```

Her må/bør du endre maxBufferSize og maxReceivedMessageSize til mer enn 65536 tegn, i tillegg til å øke maks antall objekter i en liste. Et forslag på hvordan konfigurasjonen på denne applikasjonen kan se ut er slik (endringer er uthevet):

```xml
<system.serviceModel>
  <bindings>
    <basicHttpBinding>
      <binding name="GrepSoapBinding_GrepSoap" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:01:00" allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard" **maxBufferSize="6553600"** maxBufferPoolSize="524288" **maxReceivedMessageSize="6553600"** messageEncoding="Text" textEncoding="utf-8" transferMode="Buffered" useDefaultWebProxy="true">
        <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384" maxBytesPerRead="4096" maxNameTableCharCount="16384" />
        <security mode="None">
          <transport clientCredentialType="None" proxyCredentialType="None" realm="" />
          <message clientCredentialType="UserName" algorithmSuite="Default" />
        </security>
      </binding>
    </basicHttpBinding>
  </bindings>
  <client>
    <endpoint address="http://data.udir.no/soap" binding="basicHttpBinding" **behaviorConfiguration="GrepBehavior"** bindingConfiguration="GrepSoapBinding_GrepSoap" contract="Læreplanspørringer.GrepSoap" name="GrepSoapBinding_GrepSoap" />
  </client>
  <behaviors>
    <endpointBehaviors>
      <behavior name="GrepBehavior">
        <dataContractSerializer maxItemsInObjectGraph="2147483647" />
      </behavior>
    </endpointBehaviors>
  </behaviors>
</system.serviceModel>
```

### Kode {#kode}

Nå har vi det vi trenger for å kunne bruke tjenestene. Det som gjenstår er litt kode for å faktisk kalle tjenesten.

I eksempelet her vil vi lage en WPF-basert applikasjon for å kunne søke opp læreplaner basert på tittel og gyldig fra-datoen på læreplanen. Vi vil også kunne hente en valgt læreplans vurdering og vise denne.

Først definerer vi brukergrensesnittet (XAMLen).

Her oppretter vi et enkelt stackpanel med en tekstboks for å skrive inn tittel, en datovelger for å velge gyldig fra, en knapp for å starte søk, et grid for å vise søkeresultat (med tittel, kode og gyldig fra som kolonner) og en web-browser for å vise html:

```xml

<Window x:Class="TestApplikasjon.MainWindow"

xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"

xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"

Title="MainWindow" Width="973" Closing="WindowClosing">

&lt;Grid&gt;

&lt;StackPanel&gt;

&lt;Label Content="Tittel å søke på"&gt;&lt;/Label&gt;

&lt;TextBox Name="txtTittel"&gt;&lt;/TextBox&gt;

&lt;Label Content="Gyldig Fra å søke på"&gt;&lt;/Label&gt;

&lt;DatePicker Name="dtpGyldigFra"&gt;&lt;/DatePicker&gt;

&lt;Button Name="btnSøk" Content="Søk" HorizontalAlignment="Left" Width="40" Click="BtnSøkClick"&gt;&lt;/Button&gt;

&lt;ScrollViewer MaxHeight="150"&gt;

<DataGrid Name="dgSøkeresultat" AutoGenerateColumns="False"

SelectionChanged="DgSøkeresultatSelectionChanged">

<DataGrid.Columns>

&lt;DataGridTextColumn Binding="{Binding tittel}" Header="Tittel"&gt;&lt;/DataGridTextColumn&gt;

&lt;DataGridTextColumn Binding="{Binding kode}" Header="Kode"&gt;&lt;/DataGridTextColumn&gt;

&lt;DataGridTextColumn Binding="{Binding gyldigfra}" Header="Gyldig fra"&gt;&lt;/DataGridTextColumn&gt;

</DataGrid.Columns>

&lt;/DataGrid&gt;

&lt;/ScrollViewer&gt;

&lt;Label Content="Vurdering" FontWeight="Bold"&gt;&lt;/Label&gt;

&lt;ScrollViewer MaxHeight="150"&gt;

&lt;WebBrowser Name="webBrowser"&gt;&lt;/WebBrowser&gt;

&lt;/ScrollViewer&gt;

&lt;/StackPanel&gt;

&lt;/Grid&gt;

&lt;/Window&gt;

```

Deretter definerer vi koden for å søke, og for å vise vurdering:

```c#

public partial class MainWindow : Window

{

public MainWindow()

{

InitializeComponent();

}

private GrepSoapClient Client { get; set; }

const string HtmlHeadere = @"&lt;html&gt; &lt;head&gt; <meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>

&lt;/head&gt; &lt;body&gt;";

const string HtmlSluttHeader = @"&lt;/body&gt; &lt;/html&gt;";

// Kode som kjøres når søk-knappen klikkes

private void BtnSøkClick(object sender, RoutedEventArgs e)

{

InitierProxy();

try

{

// Kjører FinnPlaner-metoden med tittel og gyldig-fra som parametere

dgSøkeresultat.ItemsSource = this.Client.FinnPlaner(

new laereplansoekrequest { gyldigfra = dtpGyldigFra.DisplayDate, tittel = txtTittel.Text }).treff;

}

catch (Exception ex)

{

if (Client.State == CommunicationState.Faulted)

{

this.Client.Abort();

}

MessageBox.Show(ex.ToString());

}

}

private void DgSøkeresultatSelectionChanged(object sender, SelectionChangedEventArgs e)

{

InitierProxy();

try

{

// Finner koden fra det valgte søkeresultatet i Grid'en

var valgtKode =

e.AddedItems.Cast&lt;laereplansoekeresultat&gt;().Select(soekeresultat =>

soekeresultat.kode).FirstOrDefault();

// Henter hele læreplanen fra tjenesten (HentPlanFraKode), og velger ut vurderingen på 'default'-språk

(fastsatt språk)

var vurdering =

Client.HentPlanFraKode(new hentlaereplanfrakoderequest { Kode = valgtKode })

.vurdering

.Where(v => v.noekkel == "default")

.Select(v => v.verdi)

.FirstOrDefault();

// Viser vurderingen i en browser

if (vurdering != null)

webBrowser.NavigateToString(HtmlHeadere + vurdering + HtmlSluttHeader);

}

catch (Exception ex)

{

if (Client.State == CommunicationState.Faulted)

{

this.Client.Abort();

}

MessageBox.Show(ex.ToString());

}

}

private void InitierProxy()

{

if (Client == null || Client.State == CommunicationState.Faulted)

Client = new GrepSoapClient();

}

private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)

{

if (Client != null && Client.State == CommunicationState.Opened)

Client.Close();

}

}

```

### Demonstrasjon {#demonstrasjon}

Når vi kjører denne applikasjonen, kan vi filtrere på tittel og gyldig fra. Om vi oppgir “Natur” som tittel og 01.01.2008 som gyldig fra, vil vi få følgende resultat:

Figur 8: Testing av applikasjon

## Rest-grensesnitt {#rest-grensesnitt}

### Utlisting av alle fagkoder i html-side med JQuery {#utlisting-av-alle-fagkoder-i-html-side-med-jquery}

Følgende html-dokument benytter JQuery og REST-grensesnittet for å liste ut en enkel html-side med lenker til alle fagkoder. Lenkene peker på URL-data – URLen, med kode og tittel som beskrivelse av lenken:

Test.html:

```xml

<!DOCTYPE html>

&lt;html&gt;

&lt;head&gt;

&lt;title&gt;Test&lt;/title&gt;

<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>

&lt;script src="http://code.jquery.com/jquery-latest.js"&gt;

&lt;/script&gt;

&lt;/head&gt;

&lt;body&gt;

&lt;p&gt;&lt;/p&gt;

&lt;script type="text/jscript"&gt;

$.getJSON("http://data.udir.no/kl06/fagkoder",

{},

function (data)

{

$.each(data, function (i, fagkoder) {$('p').append('<a href=' + fagkoder["url-data"] + '>' + fagkoder.kode + ' - ' + fagkoder.tittel + '&lt;/a&gt;&lt;br&gt;'); })

});

&lt;/script&gt;

&lt;/body&gt;

&lt;/html&gt;

```

Html-side i nettleser:

### Kombinasjon av grensesnitt (REST og OData) {#kombinasjon-av-grensesnitt-rest-og-odata}

Som et eksempel på litt mer avansert bruk, demonstrerer vi her et eksempel som tilbyr et “fritekst”-søk etter læreplaner, og mulighet for å se på detaljert informasjon om læreplanen (formålet med læreplanen). Eksempelet tar i bruk JQuery og jQuery-ui (og sannsynligvis ganske amatørmessig utført), men kan like gjerne utføres i andre teknologier.

På bildet under ser du et bilde hvor du kan skrive inn deler av kode eller tittel, og får tilbake en liste med treff. Søket går mot OData-grensesnittet, hvor du har stor frihet til å definere hva du vil hente ut, og hvordan. I dette eksempelet vil du hente tilbake kode, tittel og URL-data-feltene fra de læreplanene (maks 25) hvor læreplanens sammenslåtte kode og tittel inneholder deler av søkestrengen.

Metoden for å søke ser slik ut:

```xml

// Søker etter læreplaner

function soekEtterLaereplaner(soekestreng, maksAntallTreff) {

var url = baseurl + "odata/Læreplan?$format=json";

var filter = "&$filter=substringof('" + soekestreng.toLowerCase() + "', tolower(concat(concat(Kode, ' - '),

Tittel))) eq true";

var maksResultatFilter = "&$top=" + maksAntallTreff;

var selekterFilter = "&$select=Tittel,Kode,UrlData";

$.ajax({

type: "GET",

url: url + filter + maksResultatFilter + selekterFilter,

success: function (msg) {

// behandler resultatet

}

}

);

}

```

Denne benytter standard OData-funksjonalitet for å oppgi filter og hva den vil ha tilbake. I en søke-intensiv applikasjon vil dette spare ressurser og båndbredde for klient-applikasjon og webserveren.

Ved å klikke på ett av treffene, vil den detaljerte læreplanen hentes, og formål vises:

Fra søkeresultatet har vi både URL-data-feltet, og kode-feltet. Begge disse kan brukes for å hente ut detaljer om læreplanen. Vi er kun interessert i å vise formål, og vi velger å vise formål på “default”-språket, som vil tilsvare fastsatt språk på læreplanen:

```xml


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

```

**Komplett kode til dette eksempelet (krever jquery-ui med “accordion”-widget)**

```xml


<!DOCTYPE html>

&lt;html&gt;

&lt;head&gt;

&lt;title&gt;Læreplansøk&lt;/title&gt;

<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'/>

&lt;link type="text/css" href="css/ui-lightness/jquery-ui-1.8.14.custom.css" rel="stylesheet" /&gt;

&lt;script type="text/javascript" src="js/jquery-1.5.1.min.js"&gt;&lt;/script&gt;

&lt;script src="js/jquery-ui-1.8.14.custom.min.js" type="text/javascript"&gt;&lt;/script&gt;

&lt;/head&gt;

&lt;body&gt;

&lt;script type="text/javascript"&gt;

var baseurl = "http://data.udir.no/";

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

}

);

}

// Lister ut resultatene, og hekter på et event som gjør at formål hentes fra detaljert informasjon om læreplan når resultatet åpnes

function lastInnResultater(results) {

$.each(results, function (i, lp) {

$('#resultat').append("&lt;div id=" + lp.Kode + '><h3><a href="#"&gt;' + lp.Kode + " - " + lp.Tittel + '&lt;/a&gt;</h3><div style="height:300px" id=f' + lp.Kode + '>&lt;b&gt;Formål&lt;/b&gt;&lt;/div&gt;&lt;/div&gt;');

$("#" + lp.Kode).live("click", function () {

$.getJSON(baseurl + "kl06/" + lp.Kode,

function (f) {

$('#f' + f.kode).append('&lt;p&gt;' + hentDefaultVerdi(f.formaal) + '&lt;/p&gt;');

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

&lt;/script&gt;

<p style="font-family: Arial, Sans-Serif;

font-size: 15px;

margin-bottom: 5px;

display: block;

padding: 4px;

border: solid 1px #85b1de;

background-color: #EDF2F7;">

Søk på læreplaner: &lt;input style="width: 300px;" id="soek" name="soek" type="text"/&gt;

&lt;/p&gt;

&lt;div id="resultat"&gt;&lt;/div&gt;

&lt;/body&gt;

&lt;/html&gt;

```
