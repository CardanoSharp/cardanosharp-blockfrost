using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class TransactionUtxo
{
    [JsonPropertyName("hash")] public string Hash { get; set; }

    [JsonPropertyName("inputs")] public List<TransactionUtxoInput> Inputs { get; set; }

    [JsonPropertyName("outputs")] public List<TransactionUtxoOutput> Outputs { get; set; }
}