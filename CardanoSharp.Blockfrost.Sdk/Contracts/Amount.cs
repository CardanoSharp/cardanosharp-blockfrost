using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class Amount
	{
		[JsonPropertyName("unit")] public string Unit { get; set; }

		[JsonPropertyName("quantity")] public string Quantity { get; set; }
	}
}