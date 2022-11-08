using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class EpochPoolTxDelegation
{
	[JsonPropertyName("active_epoch")] public ulong ActiveEpoch { get; set; }

	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	[JsonPropertyName("amount")] public string Amount { get; set; }

	[JsonPropertyName("pool_id")] public string PoolId { get; set; }
}