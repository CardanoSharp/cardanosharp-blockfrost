using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IBlocksClient
{
	[Get("/blocks/latest")]
	Task<ApiResponse<Block>> GetLatestBlockAsync();

	[Get("/blocks/latest/txs?count={count}&page={page}&order={order}")]
	Task<ApiResponse<string[]>> GetLatestBlockTransactionsAsync(int count = 100, int page = 1, string order = "asc");

	[Get("/blocks/{hash_or_number}")]
	Task<ApiResponse<Block>> GetBlockAsync(string hash_or_number);

	[Get("/blocks/{hash_or_number}/next?count={count}&page={page}")]
	Task<ApiResponse<Block[]>> GetNextBlocksAsync(string hash_or_number, int count = 100, int page = 1);

	[Get("/blocks/{hash_or_number}/previous?count={count}&page={page}")]
	Task<ApiResponse<Block[]>> GetPreviousBlocksAsync(string hash_or_number, int count = 100, int page = 1);

	[Get("/blocks/slot/{slot_number}")]
	Task<ApiResponse<Block>> GetBlockForSlotNumberAsync(uint slot_number);
}