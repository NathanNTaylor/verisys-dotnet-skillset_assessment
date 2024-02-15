using WeatherForecast.Test.Fixtures;

namespace WeatherForecast.Test;

public class WeatherForecastControllerTest : IClassFixture<ControllerIntegrationFixture>
{
    private readonly HttpClient _httpClient;

    public WeatherForecastControllerTest(ControllerIntegrationFixture fixture)
    {
        _httpClient = fixture.CreateHttpClient();
    }

    [Fact]
    public void Test1()
    {
    }
}
