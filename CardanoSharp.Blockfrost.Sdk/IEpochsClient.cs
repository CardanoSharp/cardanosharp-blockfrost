using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IEpochsClient
{
	[Get("/epochs/latest/parameters")]
	Task<ApiResponse<EpochParameters>> GetLatestParamtersAsync();
}