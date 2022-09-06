using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class Transaction
	{
		[JsonPropertyName("hash")] public string Hash { get; set; }

		[JsonPropertyName("block")] public string Block { get; set; }

		[JsonPropertyName("block_height")] public uint BlockHeight { get; set; }

		[JsonPropertyName("block_time")] public ulong BlockTime { get; set; }

		[JsonPropertyName("slot")] public uint Slot { get; set; }

		[JsonPropertyName("index")] public uint Index { get; set; }

		[JsonPropertyName("output_amount")] public Amount[] OutputAmount { get; set; }

		[JsonPropertyName("fees")] public string Fees { get; set; }

		[JsonPropertyName("deposit")] public string Deposit { get; set; }

		[JsonPropertyName("size")] public ushort Size { get; set; }

		[JsonPropertyName("invalid_before")] public string? InvalidBefore { get; set; }

		[JsonPropertyName("invalid_hereafter")] public string? InvalidHereafter { get; set; }

		[JsonPropertyName("utxo_count")] public ushort UtxoCount { get; set; }

		[JsonPropertyName("withdrawal_count")] public ushort WithdrawalCount { get; set; }

		[JsonPropertyName("mir_cert_count")] public ushort MirCertCount { get; set; }

		[JsonPropertyName("delegation_count")] public ushort DelegationCount { get; set; }

		[JsonPropertyName("stake_cert_count")] public ushort StakeCertCount { get; set; }

		[JsonPropertyName("pool_update_count")] public ushort PoolUpdateCount { get; set; }

		[JsonPropertyName("pool_retire_count")] public ushort PoolRetireCount { get; set; }

		[JsonPropertyName("asset_mint_or_burn_count")] public uint AssetMintOrBurnCount { get; set; }

		[JsonPropertyName("redeemer_count")] public ushort RedeemerCount { get; set; }

		[JsonPropertyName("valid_contract")] public bool ValidContract { get; set; }
	}
}