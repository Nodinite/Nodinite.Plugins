using Newtonsoft.Json;

namespace Nodinite.Plugins.Types.SearchField.Models
{
    public class CursorLocation
    {
        public CursorLocation(int line, int ch)
        {
            Line = line;
            Ch = ch;
        }
        [JsonProperty("line")]
        public int Line { get; }
        [JsonProperty("ch")]
        public int Ch { get; }
    }
}
