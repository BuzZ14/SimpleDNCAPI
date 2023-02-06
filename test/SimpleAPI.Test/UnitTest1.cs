using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetWeatherForecasts_ReturnsAnArray()
    {
        var result = controller.Get();
        Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
    }

    [Fact]
    public void Test1()
    {

    }
}