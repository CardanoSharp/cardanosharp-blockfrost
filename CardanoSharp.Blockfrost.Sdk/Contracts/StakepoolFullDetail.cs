using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class StakepoolFullDetail
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
		/// VRF key hash
		/// </summary>
		[JsonPropertyName("vrf_key")] public string VrfKey { get; set; }

		/// <summary>
		/// Total minted blocks
		/// </summary>
		[JsonPropertyName("blocks_minted")] public int BlocksMinted { get; set; }

		/// <summary>
		/// Number of blocks minted in the current epoch
		/// </summary>
		[JsonPropertyName("blocks_epoch")] public int BlocksEpoch { get; set; }

		/// <summary>
		/// string
		/// </summary>
		[JsonPropertyName("live_stake")] public string LiveStake { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("live_size")] public decimal LiveSize { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("live_saturation")] public decimal LiveSaturation { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("live_delegators")] public int LiveDelegators { get; set; }

		/// <summary>
		/// string
		/// </summary>
		[JsonPropertyName("active_stake")] public string ActiveStake { get; set; }

		/// <summary>
		/// number
		/// </summary>
		[JsonPropertyName("active_size")] public decimal ActiveSize { get; set; }

		/// <summary>
		/// Stake pool certificate pledge
		/// </summary>
		[JsonPropertyName("declared_pledge")] public string DeclaredPledge { get; set; }

		/// <summary>
		/// Stake pool current pledge
		/// </summary>
		[JsonPropertyName("live_pledge")] public string LivePledge { get; set; }

		/// <summary>
		/// Margin tax cost of the stake pool
		/// </summary>
		[JsonPropertyName("margin_cost")] public decimal MarginCost { get; set; }

		/// <summary>
		/// Fixed tax cost of the stake pool
		/// </summary>
		[JsonPropertyName("fixed_cost")] public string FixedCost { get; set; }

		/// <summary>
		/// Bech32 reward account of the stake pool
		/// </summary>
		[JsonPropertyName("reward_account")] public string RewardAccount { get; set; }

		/// <summary>
		/// Array of strings
		/// </summary>
		[JsonPropertyName("owners")] public string[] Owners { get; set; }

		/// <summary>
		/// Array of strings
		/// </summary>
		[JsonPropertyName("registration")] public string[] Registration { get; set; }

		/// <summary>
		/// Array of strings
		/// </summary>
		[JsonPropertyName("retirement")] public string[] Retirement { get; set; }
	}
}