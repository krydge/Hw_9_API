using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hw_9_API.API
{
    public class Jokes
    {
        [JsonPropertyName("joke")]
        public string joke { get; set; }
    }
}
