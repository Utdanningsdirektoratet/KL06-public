## SOAP-grensesnitt {#soap-grensesnitt}

Her følger et enkelt eksempel på hvordan du kan ta i bruk SOAP-grensesnittet i en .Net-basert applikasjon.

![](../figurer/figur5.PNG)
Figur 5: Opprett en ny applikasjon

![](../figurer/figur6.PNG)

Figur 6: Legg til en ny tjeneste-referanse

![](../figurer/figur7.PNG)

Figur 7: Oppgi URL (http://data.udir.no/KL06/soap), trykk "GO" og OK

### Endringer i konfigurasjon {#endringer-i-konfigurasjon}

I dette tilfellet benytter vi en WCF proxy-klasse for å få tilgang til tjenesten. Denne har en del standard innstillinger, som blant annet går på hvor mange elementer man kan laste ned, og størrelsen på “pakken” fra tjenesten. Grep-tjenesten kan i utgangspunktet gi en oversikt over alle læreplaner, og dette vil overstige standardinnstillingene. For å endre dette – gå til applikasjonens app.config. Der vil du finne noen linjer som ligner på disse:

{%ace edit=false, check=false, lang='xml'%}
<basicHttpBinding>        
  <binding name="GrepSoapBinding_GrepSoap" closeTimeout="00:01:00"
    openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:01:00"
    allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard"
    maxBufferPoolSize="524288" maxBufferSize="2147483647" maxReceivedMessageSize="2147483647"
    textEncoding="utf-8" transferMode="Buffered" useDefaultWebProxy="true"
    messageEncoding="Text">
    <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384"
    maxBytesPerRead="4096" maxNameTableCharCount="16384" />
    <security mode="None">
      <transport clientCredentialType="None" proxyCredentialType="None" realm="" />
      <message clientCredentialType="UserName" algorithmSuite="Default" />
    </security>
  </binding>
</basicHttpBinding>
{%endace%}

Her må/bør du endre maxBufferSize og maxReceivedMessageSize til mer enn 65536 tegn, i tillegg til å øke maks antall objekter i en liste. Et forslag på hvordan konfigurasjonen på denne applikasjonen kan se ut er slik:

{%ace edit=false, check=false, lang='xml'%}
<system.serviceModel>
  <bindings>
    <basicHttpBinding>
      <binding name="GrepSoapBinding_GrepSoap" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:01:00" allowCookies="false" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard" maxBufferSize="6553600" maxBufferPoolSize="524288" maxReceivedMessageSize="6553600" messageEncoding="Text" textEncoding="utf-8" transferMode="Buffered" useDefaultWebProxy="true">
        <readerQuotas maxDepth="32" maxStringContentLength="8192" maxArrayLength="16384" maxBytesPerRead="4096" maxNameTableCharCount="16384" />
        <security mode="None">
          <transport clientCredentialType="None" proxyCredentialType="None" realm="" />
          <message clientCredentialType="UserName" algorithmSuite="Default" />
        </security>
      </binding>
    </basicHttpBinding>
  </bindings>
  <client>
    <endpoint address="http://data.udir.no/soap" binding="basicHttpBinding" behaviorConfiguration="GrepBehavior" bindingConfiguration="GrepSoapBinding_GrepSoap" contract="Læreplanspørringer.GrepSoap" name="GrepSoapBinding_GrepSoap" />
  </client>
  <behaviors>
    <endpointBehaviors>
      <behavior name="GrepBehavior">
        <dataContractSerializer maxItemsInObjectGraph="2147483647" />
      </behavior>
    </endpointBehaviors>
  </behaviors>
</system.serviceModel>
{%endace%}

### Kode {#kode}

Nå har vi det vi trenger for å kunne bruke tjenestene. Det som gjenstår er litt kode for å faktisk kalle tjenesten.

I eksempelet her vil vi lage en WPF-basert applikasjon for å kunne søke opp læreplaner basert på tittel på læreplanen. Vi vil også kunne hente en valgt læreplans vurdering og vise denne.

Først definerer vi brukergrensesnittet (XAMLen).

Her oppretter vi et enkelt stackpanel med en tekstboks for å skrive inn tittel, en knapp for å starte søk, et grid for å vise søkeresultat (med tittel, kode) og en web-browser for å vise html:

{%ace edit=false, check=false, lang='xml'%}
<Window x:Class="TestApplication.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:TestApplication"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525">
    <Grid>
        <StackPanel>
            <Label Content="Tittel å søke på"></Label>
            <TextBox Name="txtTittel"></TextBox>
            <Button Name="btnSøk" Content="Søk" HorizontalAlignment="Left" Width="40"
            Click="BtnSøkClick"></Button>
            <ScrollViewer MaxHeight="150">
                <DataGrid Name="dgSøkeresultat" AutoGenerateColumns="False"
                SelectionChanged="DgSøkeresultatSelectionChanged">
                    <DataGrid.Columns>
                        <DataGridTextColumn Binding="{Binding kode}" Header="Kode"></DataGridTextColumn>
                        <DataGridTextColumn Binding="{Binding gyldigfra}" Header="Gyldig fra">
                        </DataGridTextColumn>
                    </DataGrid.Columns>
                </DataGrid>
            </ScrollViewer>
            <Label Content="Vurdering" FontWeight="Bold"></Label>
            <ScrollViewer MaxHeight="150">
                <WebBrowser Name="webBrowser"></WebBrowser>
            </ScrollViewer>
        </StackPanel>
    </Grid>
</Window>
{%endace%}

Deretter definerer vi koden for å søke, og for å vise vurdering:

{%ace check=false, edit=false%}
public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
    private GrepSoapClient Client { get; set; }
    const string HtmlHeadere = @"<html> <head> <meta http-equiv='Content-Type'
    content='text/html;charset=UTF-8'> </head> <body>";
    const string HtmlSluttHeader = @"</body> </html>";
    // Kode som kjøres når søk-knappen klikkes
    private void BtnSøkClick(object sender, RoutedEventArgs e)
    {
        InitierProxy();
        try
        {
            // Kjører FinnPlaner-metoden med tittel
            dgSøkeresultat.ItemsSource = this.Client.FinnPlaner(
              new laereplansoekrequest {tittel = txtTittel.Text}).treff;
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
            var valgtKode = e.AddedItems.Cast<laereplansoekeresultat>().Select(soekeresultat =>
            soekeresultat.kode).FirstOrDefault();
            // Henter hele læreplanen fra tjenesten (HentPlanFraKode), og velger ut vurderingen på
            //'default'-språk (fastsatt språk)
            var test = Client.HentPlanFraKode(new hentlaereplanfrakoderequest {Kode = valgtKode});
            var vurdering = test.vurderingkapittel.tekst.Where(v => v.spraak == "default").Select(v =>
            v.verdi).FirstOrDefault();
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
{%endace%}

### Demonstrasjon {#demonstrasjon}

Når vi kjører denne applikasjonen, kan vi filtrere på tittel. Om vi oppgir “Natur” som tittel vil vi få følgende resultat:
![](../figurer/figur8.png)
Figur 8: Testing av applikasjon
