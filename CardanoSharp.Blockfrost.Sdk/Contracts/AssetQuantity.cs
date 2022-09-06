using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetQuantity
{
	[JsonPropertyName("asset")] public string Asset { get; set; }

	[JsonPropertyName("quantity")] public string Quantity { get; set; }
}