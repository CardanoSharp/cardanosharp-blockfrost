using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountWithdrawal
{
	/// <summary>
	/// Hash of the transaction containing the withdrawal
	/// </summary>
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	/// <summary>
	/// Withdrawal amount in Lovelaces
	/// </summary>
	[JsonPropertyName("amount")] public string Amount { get; set; }
}