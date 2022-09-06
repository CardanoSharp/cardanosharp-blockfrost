using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IScriptsClient
{
	[Get("/scripts/{script_hash}/json")]
	Task<ApiResponse<ScriptJson>> GetScriptJson(string script_hash);
}