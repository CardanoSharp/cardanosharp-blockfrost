using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class OffchainMetadata
	{
		[JsonPropertyName("name")] public string? Name { get; set; }

		[JsonPropertyName("description")] public string? Description { get; set; }

		[JsonPropertyName("ticker")] public string? Ticker { get; set; }

		[JsonPropertyName("url")] public string? Url { get; set; }

		[JsonPropertyName("logo")] public string? Logo { get; set; }

		[JsonPropertyName("decimals")] public byte? Decimals { get; set; }
	}
}