using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk
{
	public interface IPoolsClient
	{
		/// <summary>
		/// Stake pool delegators
		/// </summary>
		/// <remarks>
		/// List of current stake pools delegators.
		/// </remarks>
		/// <param name="pool_id">Bech32 or hexadecimal pool ID.</param>
		/// <param name="count">The number of results displayed on one page.</param>
		/// <param name="page">The page number for listing the results.</param>
		/// <param name="order">The ordering of items from the point of view of the blockchain,
		/// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
		/// <returns>Return the pool delegations.</returns>
		[Get("/pools/{pool_id}/delegators?count={count}&page={page}&order={order}")]
		Task<ApiResponse<Delegator[]>> GetDelegatorsAsync(string pool_id, int count = 100, int page = 1, string order = "asc");

		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <summary>
		/// List of stake pools
		/// </summary>
		/// <remarks>
		/// List of registered stake pools.
		/// </remarks>
		/// <param name="count">The number of pools per page.</param>
		/// <param name="page">The page number for listing the results.</param>
		/// <param name="order">The ordering of items from the point of view of the blockchain,
		/// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
		/// <returns>Return the list of pools.</returns>
		[Get("/pools?count={count}&page={page}&order={order}")]
		Task<ApiResponse<string[]>> GetStakepoolsAsync(int count = 100, int page = 1, string order = "asc");

		/// <summary>
		/// List of stake pools with additional information
		/// </summary>
		/// <remarks>
		/// List of registered stake pools with additional information.
		/// </remarks>
		/// <param name="count">The number of pools per page.</param>
		/// <param name="page">The page number for listing the results.</param>
		/// <param name="order">The ordering of items from the point of view of the blockchain,
		/// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
		/// <returns>Return the list of pools.</returns>
		[Get("/pools/extended?count={count}&page={page}&order={order}")]
		Task<ApiResponse<StakepoolExtended[]>> GetStakepoolsExtendedAsync(int count = 100, int page = 1, string order = "asc");

		/// <summary>
		/// Pool information.
		/// </summary>
		/// <remarks>
		/// Specific stake pool information.
		/// </remarks>
		/// <param name="pool_id">Bech32 pool ID.</param>
		/// <returns>Return the pool information content.</returns>
		[Get("/pools/{pool_id}")]
		Task<ApiResponse<StakepoolFullDetail>> GetStakepoolAsync(string pool_id);

		/// <summary>
		/// Stake pool metadata
		/// </summary>
		/// <remarks>
		/// Stake pool registration metadata.
		/// </remarks>
		/// <param name="pool_id">Bech32 pool ID.</param>
		/// <returns>Return the pool information content.</returns>
		[Get("/pools/{pool_id}/metadata")]
		Task<ApiResponse<StakepoolMetadata>> GetStakepoolMetadataAsync(string pool_id);
	}
}