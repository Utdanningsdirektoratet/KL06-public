using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kl06.Eksempler
{
    public class HentNedAltRest
    {
        public async Task HentAlleLæreplaner()
        {
            var client = new HttpClient();
            // Bruker autogenererte klasser fra Soap-referanse. Her kan man også bruke egne klasser eller dynamic
            var læreplaner = JsonConvert.DeserializeObject<List<Soap.laereplansoekeresultat>>(await client.GetStringAsync("http://data.udir.no/kl06/laereplaner"));
            foreach (var laereplansoekeresultat in læreplaner)
            {
                var læreplan = JsonConvert.DeserializeObject<Soap.laereplan>(await client.GetStringAsync(laereplansoekeresultat.urldata));
                Debug.WriteLine(læreplan.kode + " " + læreplan.tittel.First(t => t.noekkel == "default").verdi);
            }
        }

        public async Task HentAlleLæreplanerEndretEtterDato(DateTime dato)
        {
            var client = new HttpClient();

            var læreplaner = JsonConvert.DeserializeObject<dynamic>(await client.GetStringAsync("http://data.udir.no/kl06/Odata/Læreplan?$format=json&$filter=SistEndret gt datetime'" + dato.ToString("s") +"'"));
            foreach (var læreplanInfo in læreplaner.d.results)
            {
                string urlData = læreplanInfo.UrlData;
                Soap.laereplan læreplan = JsonConvert.DeserializeObject<Soap.laereplan>(await client.GetStringAsync(urlData));
                Debug.WriteLine(læreplan.kode + " " + læreplan.tittel.First(t => t.noekkel == "default").verdi);
            }
        }
    }
}