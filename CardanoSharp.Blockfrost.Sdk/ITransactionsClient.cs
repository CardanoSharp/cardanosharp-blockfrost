using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface ITransactionsClient
{
	[Get("/txs/{hash}")]
	Task<ApiResponse<Transaction>> GetTransactionAsync(string hash);

	[Headers("Content-Type: application/cbor; charset=UTF-8")]
	[Post("/tx/submit")]
	Task<ApiResponse<string>> PostSubmitTransactionAsync([Body] Stream content);
}