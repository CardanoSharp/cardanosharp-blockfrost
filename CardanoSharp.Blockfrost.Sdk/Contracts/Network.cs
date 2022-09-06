using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Network
{
	[JsonPropertyName("supply")] public Supply Supply { get; set; }

	[JsonPropertyName("stake")] public Stake Stake { get; set; }
}