using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class Network
    {
        [JsonPropertyName("supply")] public Supply Supply { get; set; }
        [JsonPropertyName("stake")] public Stake Stake { get; set; }
    }
}
