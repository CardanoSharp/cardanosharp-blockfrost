using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class Supply
    {
        [JsonPropertyName("max")] public string Max { get; set; }
        [JsonPropertyName("total")] public string Total { get; set; }
        [JsonPropertyName("circulating")] public string Circulating { get; set; }
        [JsonPropertyName("locked")] public string Locked { get; set; }
        [JsonPropertyName("treasury")] public string Treasury { get; set; }
        [JsonPropertyName("reserves")] public string Reserves { get; set; }
    }
}
