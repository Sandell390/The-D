using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace The_D
{
    public class WebsiteDataManager
    {
        [JsonProperty("website")]
        public List<WebData> Webdata { get; set; }
    }
}
