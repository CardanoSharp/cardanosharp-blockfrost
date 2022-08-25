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
	private readonly INetworkClient? _networkClient;
	private readonly IBlocksClient? _blocksClient;

	public Worker(INetworkClient? networkClient, IBlocksClient blocksClient)
	{
		_networkClient = networkClient;
		_blocksClient = blocksClient;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		// Network Calls
		var network = await _networkClient.GetNetworkInformation();
		var latestBlock = await _blocksClient.GetLatestBlock();
	}
}