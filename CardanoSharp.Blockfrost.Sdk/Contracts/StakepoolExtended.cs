using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class StakepoolExtended
    {
        /// <summary>
        /// Bech32 encoded pool ID
        /// </summary>
        [JsonPropertyName("pool_id")] public string PoolId { get; set; }

        /// <summary>
        /// Hexadecimal pool ID.
        /// </summary>
        [JsonPropertyName("hex")] public string Hex { get; set; }

        /// <summary>
        /// Active delegated amount
        /// </summary>
        [JsonPropertyName("active_stake")] public string ActiveStake { get; set; }

        /// <summary>
        /// Currently delegated amount
        /// </summary>
        [JsonPropertyName("live_stake")] public string LiveStake { get; set; }

    }
}
