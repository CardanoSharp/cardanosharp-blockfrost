using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressQuantity
{
	[JsonPropertyName("address")] public string Asset { get; set; }

	[JsonPropertyName("quantity")] public string Quantity { get; set; }
}