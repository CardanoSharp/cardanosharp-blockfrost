using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class ScriptJson
	{
		[JsonPropertyName("json")] public object? Json { get; set; }
	}
}