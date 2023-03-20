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
		/// VRF key hash
		/// </summary>
		[JsonPropertyName("url")] public string Url { get; set; }

		/// <summary>
		/// Total minted blocks
		/// </summary>
		[JsonPropertyName("hash")] public string Hash { get; set; }

		/// <summary>
		/// Number of blocks minted in the current epoch
		/// </summary>
		[JsonPropertyName("ticker")] public string Ticker { get; set; }

		/// <summary>
		/// string
		/// </summary>
		[JsonPropertyName("name")] public string Name { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("description")] public string Description { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("homepage")] public string Homepage { get; set; }
	}
}