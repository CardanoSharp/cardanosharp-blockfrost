using CardanoSharp.Blockfrost.Sdk;
using CardanoSharp.Blockfrost.Sdk.Common;
using Microsoft.Extensions.Hosting;
using Refit;

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

    public Worker(INetworkClient? networkClient)
    {
        _networkClient = networkClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Network Calls
        var network = await _networkClient.GetNetworkInformation();

    }
}