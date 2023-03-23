using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountRegistration
{
	/// <summary>
	/// Hash of the transaction containing the (de)registration certificate
	/// </summary>
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; }

	/// <summary>
	/// Action in the certificate ["registered"/"deregistered"]
	/// </summary>
	[JsonPropertyName("action")] public string Action { get; set; }
}