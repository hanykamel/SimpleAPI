using Xunit;
using  SimpleAPI.Controllers;
namespace SimpleAPI.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    WeatherForecastController controller = new WeatherForecastController(null);
   [Fact]
    public void GetReturnsMyName()
    {
        var result =  controller.Get(1);
        Assert.Equal("Hany", result.Value);


    }
}