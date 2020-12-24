using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RaccoonWars.Transcode.Models
{

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class TranscodeConfiguration
    {
        [JsonProperty("global")]
        public IEnumerable<TransocdeTargetConfiguration> GlobalRules { get; set; }

        [JsonProperty("targets")]
        public Dictionary<string, IEnumerable<TransocdeTargetConfiguration>> Targets { get;set; }

        [JsonProperty("temporaryDirectory")]
        public string TemporaryDirectory { get; set; }

        [JsonProperty("finishedDirectory")]
        public string FinishedDirectory { get; set; }

    }
}
