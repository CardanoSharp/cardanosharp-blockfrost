using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class Delegator
    {
        /// <summary>
        /// Bech32 encoded stake addresses
        /// </summary>
        [JsonPropertyName("address")] public string Address { get; set; }

        /// <summary>
        /// Currently delegated amount
        /// </summary>
        [JsonPropertyName("live_stake")] public string LiveStake { get; set; }

    }
}
