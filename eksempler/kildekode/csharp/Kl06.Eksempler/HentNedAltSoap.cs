using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kl06.Eksempler
{
    public class HentNedAltSoap
    {
        public async Task Test()
        {
            var client = new Soap.GrepSoapClient();
            var læreplaner = await client.FinnPlanerAsync(null);
            foreach (var laereplansoekeresultat in læreplaner.treff)
            {
                var læreplan =
                    client.HentPlanFraKode(new Soap.hentlaereplanfrakoderequest {Kode = laereplansoekeresultat.kode});
                Debug.WriteLine(læreplan.kode + " " + læreplan.tittel.First(t => t.noekkel == "default").verdi);
            }
        } 

    }
}