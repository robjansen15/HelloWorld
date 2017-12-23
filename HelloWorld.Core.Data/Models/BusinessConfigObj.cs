using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloWorld.Core.Data.Models
{
    class BusinessConfigObj
    {
        [JsonProperty(PropertyName = "entity")]
        public string Entity { get; set; }
    }
}
