using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAddressesClient
{
	[Get("/addresses/{address}/utxos?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressUtxo[]>> GetAddressUtxosAsync(string address, int count = 100, int page = 1, string order = "asc");
}