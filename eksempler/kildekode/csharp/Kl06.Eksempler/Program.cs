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
            new HentNedAltRest().Test().Wait();
            new HentNedAltSoap().Test().Wait();
        }
    }
}
