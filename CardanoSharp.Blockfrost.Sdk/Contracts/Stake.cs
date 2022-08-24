using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class Stake
    {
        [JsonPropertyName("live")] public string Live { get; set; }
        [JsonPropertyName("Active")] public string Active { get; set; }
    }
}
