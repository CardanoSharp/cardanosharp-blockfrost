using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk
{
	public interface IBlocksClient
	{
		[Get("/blocks/latest")]
		Task<ApiResponse<Block>> GetLatestBlock();
	}
}