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

	[Get("/epochs/{number}/stakes?count={count}&page={page}")]
	Task<ApiResponse<StakeAddressStakePoolDelegation[]>> GetStakeDistributionAsync(uint number, int count = 100, int page = 1);

	[Get("/epochs/{number}/stakes/{pool_id}?count={count}&page={page}")]
	Task<ApiResponse<StakeAddressDelegation[]>> GetStakeDistributionByPoolAsync(uint number, string pool_id, int count = 100, int page = 1);
}