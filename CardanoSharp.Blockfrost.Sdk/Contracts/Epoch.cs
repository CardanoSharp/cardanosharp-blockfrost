using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Epoch
{
	[JsonPropertyName("epoch")] public uint EpochNumber { get; set; }

	[JsonPropertyName("start_time")] public ulong StartTime { get; set; }

	[JsonPropertyName("end_time")] public ulong EndTime { get; set; }

	[JsonPropertyName("first_block_time")] public ulong FirstBlockTime { get; set; }

	[JsonPropertyName("last_block_time")] public ulong LastBlockTime { get; set; }

	[JsonPropertyName("block_count")] public uint BlockCount { get; set; }

	[JsonPropertyName("tx_count")] public uint TxCount { get; set; }

	[JsonPropertyName("output")] public string Output { get; set; }

	[JsonPropertyName("fees")] public string Fees { get; set; }

	[JsonPropertyName("active_stake")] public string ActiveStake { get; set; }
}