using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kl06.Eksempler.Modell
{
    [DataContract (Name = "fagkategori")]
    [Description("Kategorisering av fag etter innhold. Benyttes av statistikkavdelingen i Udir. Fagkategori er høyeste nivå, og har fagområder under seg")]
    public class Fagkategori : HovedElement
    {
        
    }
}
