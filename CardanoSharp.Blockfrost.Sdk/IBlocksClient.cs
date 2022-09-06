using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IBlocksClient
{
	[Get("/blocks/latest")]
	Task<ApiResponse<Block>> GetLatestBlockAsync();

	[Get("/blocks/{hash_or_number}")]
	Task<ApiResponse<Block>> GetBlockAsync(string hash_or_number);
}