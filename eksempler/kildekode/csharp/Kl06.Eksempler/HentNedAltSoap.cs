using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kl06.Eksempler.Soap;

namespace Kl06.Eksempler
{
    public class HentNedAltSoap
    {
        public async Task HentAlleLæreplaner()
        {
            var client = new GrepSoapClient(); 
            var læreplaner = await client.FinnPlanerAsync(null); // Null som argument gir tilbake alle
            foreach (var laereplansoekeresultat in læreplaner.treff)
            {
                var læreplan =
                    client.HentPlanFraKode(new hentlaereplanfrakoderequest {Kode = laereplansoekeresultat.kode});
                Debug.WriteLine(læreplan.kode + " " + læreplan.tittel.First(t => t.spraak == "default").verdi);
            }
        }

        public async Task HentAlleLæreplanerEndretEtterDato(DateTime dato)
        {
            var client = new GrepSoapClient();
            // Setter sist endret for å hente ut alle endringer etter denne datao
            var læreplaner = await client.FinnPlanerAsync(new laereplansoekrequest {sistendret = dato} ); 

            if (læreplaner.treff.Any() == false)
            {
                Debug.WriteLine("Ingen endringer siden " + dato.ToShortDateString());
            }

            foreach (var laereplansoekeresultat in læreplaner.treff)
            {
                var læreplan =
                    client.HentPlanFraKode(new hentlaereplanfrakoderequest { Kode = laereplansoekeresultat.kode });
                Debug.WriteLine(læreplan.kode + " " + læreplan.tittel.First(t => t.spraak == "default").verdi);
            }
        }

    }
}