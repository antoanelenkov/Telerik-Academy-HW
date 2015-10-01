using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProcessing
{
    class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
