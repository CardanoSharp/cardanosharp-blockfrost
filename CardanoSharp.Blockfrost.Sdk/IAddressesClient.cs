using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAddressesClient
{
	[Get("/addresses/{address}/utxos")]
	Task<ApiResponse<AddressUtxo[]>> GetAddressUtxosAsync(string address);
}