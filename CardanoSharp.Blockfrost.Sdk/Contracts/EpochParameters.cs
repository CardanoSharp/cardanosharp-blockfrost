using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class EpochParameters
{
	[JsonPropertyName("epoch")] public uint Epoch { get; set; }

	[JsonPropertyName("min_fee_a")] public uint MinFeeA { get; set; }

	[JsonPropertyName("min_fee_b")] public uint MinFeeB { get; set; }

	[JsonPropertyName("max_block_size")] public uint MaxBlockSize { get; set; }

	[JsonPropertyName("max_tx_size")] public uint MaxTxSize { get; set; }

	[JsonPropertyName("max_block_header_size")] public uint MaxBlockHeaderSize { get; set; }

	[JsonPropertyName("key_deposit")] public string KeyDeposit { get; set; }

	[JsonPropertyName("pool_deposit")] public string PoolDeposit { get; set; }

	[JsonPropertyName("e_max")] public uint EMax { get; set; }

	[JsonPropertyName("n_opt")] public uint NOpt { get; set; }

	[JsonPropertyName("a0")] public decimal A0 { get; set; }

	[JsonPropertyName("rho")] public decimal Rho { get; set; }

	[JsonPropertyName("tau")] public decimal Tau { get; set; }

	[JsonPropertyName("decentralisation_param")] public decimal DecentralisationParam { get; set; }

	[JsonPropertyName("extra_entropy")] public string? ExtraEntropy { get; set; }

	[JsonPropertyName("protocol_major_ver")] public ushort ProtocolMajorVer { get; set; }

	[JsonPropertyName("protocol_minor_ver")] public ushort ProtocolMinorVer { get; set; }

	[JsonPropertyName("min_utxo")] public string MinUtxo { get; set; }

	[JsonPropertyName("min_pool_cost")] public string MinPoolCost { get; set; }

	[JsonPropertyName("nonce")] public string Nonce { get; set; }

	[JsonPropertyName("cost_models")] public object? CostModels { get; set; }

	[JsonPropertyName("price_mem")] public decimal? PriceMem { get; set; }

	[JsonPropertyName("price_step")] public decimal? PriceStep { get; set; }

	[JsonPropertyName("max_tx_ex_mem")] public string? MaxTxExMem { get; set; }

	[JsonPropertyName("max_tx_ex_steps")] public string? MaxTxExSteps { get; set; }

	[JsonPropertyName("max_block_ex_mem")] public string? MaxBlockExMem { get; set; }

	[JsonPropertyName("max_block_ex_steps")] public string? MaxBlockExSteps { get; set; }

	[JsonPropertyName("max_val_size")] public string? MaxValSize { get; set; }

	[JsonPropertyName("collateral_percent")] public ushort? CollateralPercent { get; set; }

	[JsonPropertyName("max_collateral_inputs")] public ushort? MaxCollateralInputs { get; set; }

	[JsonPropertyName("coins_per_utxo_size")] public string? CoinsPerUtxoSize { get; set; }

	[JsonPropertyName("coins_per_utxo_word")] public string? CoinsPerUtxoWord { get; set; }
}