using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nodinite.Plugins.AutoFields
{
    public class AutoField
    {
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public IValues Values { get; set; }
        [JsonProperty("schema")]
        public List<ISchema> Schema { get; set; }
        public void AddSchema(ISchema schema)
        {
            this.Schema.Add(schema);
        }
    }
}
