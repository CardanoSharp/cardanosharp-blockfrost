using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IEpochsClient
{
	[Get("/epochs/latest/parameters")]
	Task<ApiResponse<EpochParameters>> GetLatestParamtersAsync();

	[Get("/epochs/latest")]
	Task<ApiResponse<Epoch>> GetLatestAsync();

	[Get("/epochs/{number}")]
	Task<ApiResponse<Epoch>> GetAsync(uint number);
}