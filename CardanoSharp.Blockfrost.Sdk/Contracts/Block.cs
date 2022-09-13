using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Block
{
	[JsonPropertyName("time")] public ulong Time { get; set; }

	[JsonPropertyName("height")] public ulong? Height { get; set; }

	[JsonPropertyName("hash")] public string Hash { get; set; }

	[JsonPropertyName("slot")] public ulong? Slot { get; set; }

	[JsonPropertyName("epoch")] public uint? Epoch { get; set; }

	[JsonPropertyName("epoch_slot")] public uint? EpochSlot { get; set; }

	[JsonPropertyName("slot_leader")] public string SlotLeader { get; set; }

	[JsonPropertyName("size")] public uint Size { get; set; }

	[JsonPropertyName("tx_count")] public uint TxCount { get; set; }

	[JsonPropertyName("output")] public string? Output { get; set; }

	[JsonPropertyName("fees")] public string? Fees { get; set; }

	[JsonPropertyName("block_vrf")] public string? BlockVrf { get; set; }

	[JsonPropertyName("op_cert")] public string? OpCert { get; set; }

	[JsonPropertyName("op_cert_counter")] public string? OpCertCounter { get; set; }

	[JsonPropertyName("previous_block")] public string? PreviousBlock { get; set; }

	[JsonPropertyName("next_block")] public string? NextBlock { get; set; }

	[JsonPropertyName("confirmations")] public uint Confirmations { get; set; }
}