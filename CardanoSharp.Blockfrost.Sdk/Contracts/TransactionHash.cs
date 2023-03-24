using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class TransactionHash
	{
		[JsonPropertyName("tx_hash")] public string TxHash { get; set; }
	}
}