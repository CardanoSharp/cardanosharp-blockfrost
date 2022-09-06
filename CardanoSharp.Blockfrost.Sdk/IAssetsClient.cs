using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAssetsClient
{
	[Get("/assets?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AssetQuantity[]>> GetAssets(int count = 100, int page = 1, string order = "asc");

	[Get("/assets/{asset}")]
	Task<ApiResponse<AssetDetails>> GetAsset(string asset);

	[Get("/assets/{asset}/addresses?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressQuantity[]>> GetAssetAddresses(string asset, int count = 100, int page = 1, string order = "asc");
}