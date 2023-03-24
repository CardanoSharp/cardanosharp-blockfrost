using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetHistory
{
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	[JsonPropertyName("amount")] public string Amount { get; set; }

	[JsonPropertyName("action")] public string Action { get; set; }
}