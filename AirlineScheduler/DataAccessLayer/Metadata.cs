using System;
using System.Collections.Generic;
using System.Text;

namespace Novetta.Dapr.AirlineScheduler.DataAccessLayer
{
    public class Metadata
    {
        public static Dictionary<string, string> Cities = new Dictionary<string, string>() {
            { "BOS", "Boston" },
            { "NYC", "New York" },
            { "LA", "Lost Angeles" },
            { "TKO", "Tokyo" },
            { "PRS", "Paris" },
            { "LON", "London" }
        };

        public static Dictionary<string, string> Airlines = new Dictionary<string, string>() {
            { "UA", "United Airlines" },
            { "NWA", "Northwest Airlines" },
            { "AER", "Aer Lingus" },
            { "FR", "Air France" },
            { "EA", "El-Al Airlines" },
            { "VA", "Virgin Atlantic" }
        };
    }
}
