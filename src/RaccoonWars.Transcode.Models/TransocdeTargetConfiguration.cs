using Newtonsoft.Json;

namespace RaccoonWars.Transcode.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class TransocdeTargetConfiguration
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("outputDirectory")]
        public string OutputDirectory { get; set; }

        [JsonProperty("executableArguments")]
        public string ExecutableArguments { get; set; }
    }
}
