using System.Text.Json;
using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetDetails
{
	[JsonPropertyName("asset")] public string Asset { get; set; }

	[JsonPropertyName("policy_id")] public string PolicyId { get; set; }

	[JsonPropertyName("asset_name")] public string? AssetName { get; set; }

	[JsonPropertyName("fingerprint")] public string Fingerprint { get; set; }

	[JsonPropertyName("quantity")] public string Quantity { get; set; }

	[JsonPropertyName("initial_mint_tx_hash")] public string InitialMintTxHash { get; set; }

	[JsonPropertyName("mint_or_burn_count")] public uint MintOrBurnCount { get; set; }

	[JsonPropertyName("onchain_metadata")] public JsonElement? OnchainMetadata { get; set; }

	[JsonPropertyName("metadata")] public OffchainMetadata? Metadata { get; set; }
}