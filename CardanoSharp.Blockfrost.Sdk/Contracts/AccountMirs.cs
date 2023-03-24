using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountMirs
{
	/// <summary>
	/// Hash of the transaction containing the MIR
	/// </summary>
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	/// <summary>
	/// MIR amount in Lovelaces
	/// </summary>
	[JsonPropertyName("amount")] public string Amount { get; set; }
}