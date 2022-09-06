using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface INetworkClient
{
	[Get("/network")]
	Task<ApiResponse<Network>> GetNetworkInformation();
}