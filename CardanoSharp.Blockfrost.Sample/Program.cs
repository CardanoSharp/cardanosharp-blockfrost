using CardanoSharp.Blockfrost.Sdk;
using CardanoSharp.Blockfrost.Sdk.Common;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((hostContext, services) =>
	{
		var apiKey = hostContext.Configuration["Blockfrost:ApiKey"];
		var baseUrl = hostContext.Configuration["Blockfrost:BaseUrl"];
		var authConfig = new AuthHeaderConfiguration(apiKey, baseUrl);
		services.AddBlockfrost(authConfig);

		services.AddHostedService<Worker>();
	})
	.Build();
await host.RunAsync();

public class Worker : BackgroundService
{
	private readonly INetworkClient _networkClient;
	private readonly ITransactionsClient _transactionsClient;
	private readonly IAssetsClient _assetsClient;
	private readonly IScriptsClient _scriptsClient;
	private readonly IBlocksClient _blocksClient;

	public Worker(
		INetworkClient networkClient,
		ITransactionsClient transactionsClient,
		IAssetsClient assetsClient,
		IScriptsClient scriptsClient,
		IBlocksClient blocksClient)
	{
		_networkClient = networkClient;
		_transactionsClient = transactionsClient;
		_assetsClient = assetsClient;
		_scriptsClient = scriptsClient;
		_blocksClient = blocksClient;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		// Network Calls
		var network = await _networkClient.GetNetworkInformation();
		var tx = await _transactionsClient.GetTransaction("ad768ec1f3326aaf0b7a2b8284b268258bfbb8b60ff54321956bb2c4cf08eeae");
		TestTxSubmit();
		//var firstPage = await _assetsClient.GetAssets();
		//var secondHalfPage = await _assetsClient.GetAssets(50, 2);
		//var nftAsset = await _assetsClient.GetAsset("d865f9a1aff32c21d9471f328879bcdb070aa31e2189e0d997c675f254455354424f583030323139");
		//var ftAsset = await _assetsClient.GetAsset("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
		//var ftAssetAddrs = await _assetsClient.GetAssetAddresses("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
		//var ftAssetTxs = await _assetsClient.GetAssetTransactions("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
		//var policyAssets = await _assetsClient.GetPolicyAssets("f65bde2d672f42dfcfae6ed93f360fcd60518dcb91ea96c1d7567b55");
		//var scriptJson = await _scriptsClient.GetScriptJson("7ab6b893e3e9b1b8d6bb5f93ecf99694a6611d13f64678e2c5c7986c");
		var latest = await _blocksClient.GetLatestBlock();
		var block = await _blocksClient.GetBlock(latest!.Content!.PreviousBlock!);
	}

	private void TestTxSubmit()
	{
		//var txCbor = "84a400838258200dbfc4ecdea2b4df9ae55dbc3ec581c5080be50ea7487f207631c39505d8af8a018258201837efed9f36335bdbfdad59944ed9278c5e0e6a3ddc43b82cbea479e1c54203028258201837efed9f36335bdbfdad59944ed9278c5e0e6a3ddc43b82cbea479e1c54203030184825839008ac3e682a6745dcca62099c8022da724bfa02b8743beab318c9708c97d43e4690624bf0c576ba2a3d070202998740e77cb5d7ffa985b9465821a0017ad4aa2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e18c8581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249500182583900e1deba87bcfca7bdc70217b3a8d5a126e73c938f3a1b288a71a2a54fe7236cb13ff18de175aafa3896acceb361ad7340ead54a694f99187d821a0017ad4aa1581ceb94702168e55e2fb79823efa3ab362866b9d2d97cb563b825e7b2dba14a474c4f4245303030313101825839008ac3e682a6745dcca62099c8022da724bfa02b8743beab318c9708c97d43e4690624bf0c576ba2a3d070202998740e77cb5d7ffa985b9465821a00656c1ba2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e1a00d9e1c7581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249501a5526450082583900e1deba87bcfca7bdc70217b3a8d5a126e73c938f3a1b288a71a2a54fe7236cb13ff18de175aafa3896acceb361ad7340ead54a694f99187d821a003e63f2a2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e1a09c0ae2f581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249501aa2696cd0021a00038e25031a040f32a9a10082825820b84056d4943b44d6804a65fbdf346cd47b3321c18497df5913a5bbe39fbc10b85840d565558868aad70d43c3aa1bfe18e69db45764a7454f1fd72ffa18e2f22060e575121b1393d48e3061146694cb3da77b2f6fdd7d72b13de7b1ad01c990272b0982582081fcd280a35e4d91c4044be1833f337b880b6f3dfacfe2d9bb07dd43c6a96d7a5840084083ca21a3f5a7a460220701a875fc2907215b1ee2d0b7eb5be9b18a16140144ab29fb724e76f2f28383d45f0fef7985a3581c758cd5297a414721fb305c0af5f6";
		//byte[] txBytes = txCbor.HexToByteArray();

		//try
		//{
		//	using (MemoryStream stream = new MemoryStream(txBytes))
		//	{
		//		var result = await _transactionsClient.SubmitTransaction(stream);
		//	}
		//}
		//catch (Exception ex)
		//{
		//	ex.GetType();
		//	throw;
		//}

		//produced - ad768ec1f3326aaf0b7a2b8284b268258bfbb8b60ff54321956bb2c4cf08eeae
	}
}