using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class StakepoolMetadata
	{
		/// <summary>
		/// Bech32 encoded pool ID
		/// </summary>
		[JsonPropertyName("pool_id")] public string PoolId { get; set; }

		/// <summary>
		/// Hexadecimal pool ID.
		/// </summary>
		[JsonPropertyName("hex")] public string Hex { get; set; }

		/// <summary>
		/// URL to the stake pool metadata
		/// </summary>
		[JsonPropertyName("url")] public string? Url { get; set; }

		/// <summary>
		/// Hash of the metadata file
		/// </summary>
		[JsonPropertyName("hash")] public string? Hash { get; set; }

		/// <summary>
		/// Ticker of the stake pool
		/// </summary>
		[JsonPropertyName("ticker")] public string? Ticker { get; set; }

		/// <summary>
		/// Name of the stake pool
		/// </summary>
		[JsonPropertyName("name")] public string? Name { get; set; }

		/// <summary>
		/// Description of the stake pool
		/// </summary>
		[JsonPropertyName("description")] public string? Description { get; set; }

		/// <summary>
		/// Home page of the stake pool
		/// </summary>
		[JsonPropertyName("homepage")] public string? Homepage { get; set; }
	}
}