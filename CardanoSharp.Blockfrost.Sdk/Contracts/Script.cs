using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class Script
	{
		[JsonPropertyName("script_hash")] public string ScriptHash { get; set; }

		[JsonPropertyName("type")] public string Type { get; set; }

		[JsonPropertyName("serialised_size")] public uint? SerialisedSize { get; set; }
	}
}