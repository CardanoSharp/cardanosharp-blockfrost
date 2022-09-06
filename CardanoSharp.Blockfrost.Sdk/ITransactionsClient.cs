using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface ITransactionsClient
{
	[Get("/txs/{hash}")]
	Task<ApiResponse<Transaction>> GetTransaction(string hash);

	[Headers("Content-Type: application/cbor; charset=UTF-8")]
	[Post("/tx/submit")]
	Task<ApiResponse<string>> SubmitTransaction([Body] Stream content);
}