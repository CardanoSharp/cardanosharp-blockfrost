using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAccountClient
{
	[Get("/accounts/{stake_address}/delegations?count={count}&page={page}&order={order}")]
	Task<ApiResponse<EpochPoolTxDelegation[]>> GetAccountDelegationHistory(string stake_address, int count = 100, int page = 1, string order = "asc");
}