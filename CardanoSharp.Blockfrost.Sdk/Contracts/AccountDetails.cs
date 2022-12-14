using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountDetails
{
    /// <summary>
    /// Bech32 stake address
    /// </summary>
    [JsonPropertyName("stake_address")] public string StakeAddress { get; set; }

    /// <summary>
    /// Registration state of an account
    /// </summary>
    [JsonPropertyName("active")] public bool Active { get; set; }

    /// <summary>
    /// Epoch of the most recent action - registration or deregistration
    /// </summary>
    [JsonPropertyName("active_epoch")] public uint ActiveEpoch { get; set; }

    /// <summary>
    /// Balance of the account in Lovelaces
    /// </summary>
    [JsonPropertyName("controlled_amount")] public string ControlledAmount { get; set; }

    /// <summary>
    /// Sum of all rewards for the account in Lovelaces
    /// </summary>
    [JsonPropertyName("rewards_sum")] public string RewardsSum { get; set; }

    /// <summary>
    /// Sum of all the withdrawals for the account in Lovelaces
    /// </summary>
    [JsonPropertyName("withdrawals_sum")] public string WithdrawalsSum { get; set; }

    /// <summary>
    /// Sum of all funds from reserves for the account in Lovelaces
    /// </summary>
    [JsonPropertyName("reserves_sum")] public string ReservesSum { get; set; }

    /// <summary>
    /// Sum of all funds from treasury for the account in Lovelaces
    /// </summary>
    [JsonPropertyName("treasury_sum")] public string TreasurySum { get; set; }

    /// <summary>
    /// Sum of available rewards that haven't been withdrawn yet for the account in Lovelaces
    /// </summary>
    [JsonPropertyName("withdrawable_amount")] public string WithdrawableAmount { get; set; }

    /// <summary>
    /// Bech32 pool ID that owns the account
    /// </summary>
    [JsonPropertyName("pool_id")] public string PoolId { get; set; }
}