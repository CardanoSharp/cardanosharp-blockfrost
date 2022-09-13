using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAddressesClient
{
	[Get("/addresses/{address}/utxos?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressUtxo[]>> GetAddressUtxosAsync(string address, int count = 100, int page = 1, string order = "asc");

    [Get("/addresses/{address}/transactions?count={count}&page={page}&order={order}&from={from}&to={to}")]
    Task<ApiResponse<AssetTransaction[]>> GetTransactionsAsync(string address, string from, string to ,int count = 100, int page = 1, string order = "asc");
}