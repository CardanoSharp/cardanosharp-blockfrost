using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class OffchainMetadata
	{
		[JsonPropertyName("name")] public string? name { get; set; }

		[JsonPropertyName("description")] public string? description { get; set; }

		[JsonPropertyName("ticker")] public string? ticker { get; set; }

		[JsonPropertyName("url")] public string? url { get; set; }

		[JsonPropertyName("logo")] public string? logo { get; set; }

		[JsonPropertyName("decimals")] public byte? decimals { get; set; }
	}
}