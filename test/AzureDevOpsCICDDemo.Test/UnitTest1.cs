using AzureDevOpsDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AzureDevOpsCICDDemo.Test;

public class UnitTest1
{

    [Fact]
    public void GetReturnsMyName()
    {
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<WeatherForecastController>();
        var svc = new WeatherForecastController(logger);
        var result = svc.Get();
        Assert.Contains("WeatherForecast", result.ToString());
    }

    [Fact]
    public void UnitTest()
    {
        Assert.True(1 == 1);
    }
}