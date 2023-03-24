using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAddressesClient
{
	[Get("/addresses/{address}/utxos?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressUtxo[]>> GetAddressUtxosAsync(string address, int count = 100, int page = 1, string order = "asc");

	[Get("/addresses/{address}/utxos/{asset}?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressUtxo[]>> GetAddressUtxosOfAssetAsync(string address, string asset, int count = 100, int page = 1, string order = "asc");

	[Get("/addresses/{address}/transactions?count={count}&page={page}&order={order}&from={from}&to={to}")]
	Task<ApiResponse<AssetTransaction[]>> GetTransactionsAsync(string address, string from, string to, int count = 100, int page = 1, string order = "asc");

	[Get("/addresses/{address}")]
	Task<ApiResponse<AddressInfo>> GetAddressInfoAsync(string address);

	[Get("/addresses/{address}/extended")]
	Task<ApiResponse<AddressExtended>> GetAddressInfoExtendedAsync(string address);

	[Get("/addresses/{address}/total")]
	Task<ApiResponse<AddressTotals>> GetAddressTotalsAsync(string address);
}