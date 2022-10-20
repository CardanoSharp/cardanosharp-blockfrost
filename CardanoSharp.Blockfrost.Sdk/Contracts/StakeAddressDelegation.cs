using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class StakeAddressDelegation
{
	[JsonPropertyName("stake_address")] public string StakeAddress { get; set; }

	[JsonPropertyName("amount")] public string Amount { get; set; }
}