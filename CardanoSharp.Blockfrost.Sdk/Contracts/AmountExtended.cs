using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class AmountExtended
	{
		[JsonPropertyName("unit")] public string Unit { get; set; }

		[JsonPropertyName("quantity")] public string Quantity { get; set; }

		[JsonPropertyName("decimals")] public ushort? Decimals { get; set; }

		[JsonPropertyName("has_nft_onchain_metadata")] public bool HasNftOnchainMetadata { get; set; }
	}
}