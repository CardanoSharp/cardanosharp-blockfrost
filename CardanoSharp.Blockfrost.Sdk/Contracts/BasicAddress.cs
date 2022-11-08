using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class BasicAddress
{
	[JsonPropertyName("address")] public string Address { get; set; }
}