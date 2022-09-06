using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAssetsClient
{
	[Get("/assets?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AssetQuantity[]>> GetAssetsAsync(int count = 100, int page = 1, string order = "asc");

	[Get("/assets/{asset}")]
	Task<ApiResponse<AssetDetails>> GetAssetAsync(string asset);

	[Get("/assets/{asset}/addresses?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressQuantity[]>> GetAssetAddressesAsync(string asset, int count = 100, int page = 1, string order = "asc");

	[Get("/assets/{asset}/transactions?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AssetTransaction[]>> GetAssetTransactionsAsync(string asset, int count = 100, int page = 1, string order = "asc");

	[Get("/assets/policy/{policy_id}?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AssetQuantity[]>> GetPolicyAssetsAsync(string policy_id, int count = 100, int page = 1, string order = "asc");
}