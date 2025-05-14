namespace interplanetary_delivery_simulator.planetary_resources.Configuration;

public class PlanetConfiguration : IHostedService
{
    private static readonly string PLANET_FILE_PATH = "";
    private readonly IServiceProvider _serviceProvider;

    public PlanetConfiguration(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        InitializePlanets();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public void InitializePlanets()
    {
        
    }
}