using System.Text.Json;
using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class ScriptJson
	{
		[JsonPropertyName("json")] public JsonElement? Json { get; set; }
	}
}