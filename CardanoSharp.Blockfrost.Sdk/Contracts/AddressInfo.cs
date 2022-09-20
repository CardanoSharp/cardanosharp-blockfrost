using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressInfo
{
    [JsonPropertyName("address")] public string Address { get; set; }

    [JsonPropertyName("amount")] public Amount[] Amount { get; set; }

    [JsonPropertyName("stake_address")] string StakeAddress { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; }

    [JsonPropertyName("script")] public bool Script { get; set; }
}