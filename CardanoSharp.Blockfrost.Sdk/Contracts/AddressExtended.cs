using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressExtended
{
	[JsonPropertyName("address")] public string Address { get; set; }

	[JsonPropertyName("amount")] public AmountExtended[] Amount { get; set; }

	[JsonPropertyName("stake_address")] public string StakeAddress { get; set; }

	[JsonPropertyName("type")] public string Type { get; set; }

	[JsonPropertyName("script")] public bool Script { get; set; }
}