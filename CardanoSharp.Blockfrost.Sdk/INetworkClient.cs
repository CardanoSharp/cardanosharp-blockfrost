using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk
{
    public interface INetworkClient
    {
        [Get("/network")]
        Task<ApiResponse<Network>> GetNetworkInformation();
    }
}
