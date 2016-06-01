using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl06.Eksempler
{
    class Program
    {
        static void Main(string[] args)
        {
            new HentNedAltRest().HentAlleLæreplanerEndretEtterDato(DateTime.Now.AddDays(-70)).Wait();

            new HentNedAltRest().HentAlleLæreplaner().Wait();
            new HentNedAltSoap().HentAlleLæreplaner().Wait();
            // Henter ned alle læreplaner som er endret den siste uka
            new HentNedAltSoap().HentAlleLæreplanerEndretEtterDato(DateTime.Now.AddDays(-7)).Wait();


        }
    }
}
