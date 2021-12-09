using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace The_D
{
    public class WebData
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }

    }
}
