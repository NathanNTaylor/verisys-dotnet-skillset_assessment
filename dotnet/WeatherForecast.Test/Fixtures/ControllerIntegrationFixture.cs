using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace WeatherForecast.Test.Fixtures;

public class ControllerIntegrationFixture
{
    private readonly WebApplicationFactory<Program> _application;

    public ControllerIntegrationFixture()
    {
        _application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder => { builder.ConfigureTestServices(services => { }); });
    }

    public HttpClient CreateHttpClient()
    {
        return _application.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
    }
}
