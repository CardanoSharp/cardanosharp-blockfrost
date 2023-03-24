using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressTxHashes
{
	[JsonPropertyName("address")] public string Address { get; set; }

	[JsonPropertyName("transactions")] public TransactionHash[] Transactions { get; set; }
}