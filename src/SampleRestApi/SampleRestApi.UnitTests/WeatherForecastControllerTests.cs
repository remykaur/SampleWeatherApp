using Microsoft.Extensions.Logging;
using Moq;
using SampleRestApi.Controllers;
using Xunit;

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

            Assert.NotNull(result);

        }
    }
}
