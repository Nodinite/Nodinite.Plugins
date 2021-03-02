using Newtonsoft.Json;

namespace Nodinite.Plugins.Types.SearchField.Models
{
    public class InputSelection
    {
        [JsonProperty("start")]
        public CursorLocation Start { get; set; }

        [JsonProperty("end")]
        public CursorLocation End { get; set; }
    }
}
