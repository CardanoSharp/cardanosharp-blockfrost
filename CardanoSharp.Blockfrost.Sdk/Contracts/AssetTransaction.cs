using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetTransaction
{
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	[JsonPropertyName("tx_index")] public uint TxIndex { get; set; }

	[JsonPropertyName("block_height")] public uint BlockHeight { get; set; }

	[JsonPropertyName("block_time")] public ulong BlockTime { get; set; }
}