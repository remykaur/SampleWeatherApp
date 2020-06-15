using Microsoft.Extensions.Logging;
using Moq;
using SampleRestApi.Controllers;
using Xunit;
using FluentAssertions;

namespace SampleRestApi.UnitTests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void WeatherForecastControllerTest()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();

            var sut = new WeatherForecastController(mockLogger.Object);

            var result = sut.Get();

            result
                .Should()
                .NotBeNull();

            result
                .Should()
                .HaveCountGreaterOrEqualTo(1);
        }
    }
}
