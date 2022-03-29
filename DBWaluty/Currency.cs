using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWaluty
{
    public class Currency
    {
        [JsonProperty("disclaimer")]
        public string disclaimer { get; set; }

        [JsonProperty("license")]
        public string license { get; set; }

        [JsonProperty("timestamp")]
        public int timestamp { get; set; }

        [JsonProperty("base")]
        public string baseCurrency { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, float> rates { get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            output += rates["PLN"];

            return output;
        }
    }
}
