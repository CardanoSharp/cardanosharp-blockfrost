using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Stake
{
	[JsonPropertyName("live")] public string Live { get; set; }

	[JsonPropertyName("Active")] public string Active { get; set; }
}