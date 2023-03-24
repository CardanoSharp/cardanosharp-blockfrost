using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressUtxo
{
	[JsonPropertyName("address")] public string Address { get; set; }

	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	[JsonPropertyName("output_index")] public ushort OutputIndex { get; set; }

	[JsonPropertyName("amount")] public UnitQuantity[] Amount { get; set; }

	[JsonPropertyName("block")] public string Block { get; set; }

	[JsonPropertyName("data_hash")] public string? DataHash { get; set; }

	[JsonPropertyName("inline_datum")] public string? InlineDatum { get; set; }

	[JsonPropertyName("reference_script_hash")] public string? ReferenceScriptHash { get; set; }
}