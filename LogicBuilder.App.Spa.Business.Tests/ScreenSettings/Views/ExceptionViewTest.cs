namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings.Views
{
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Text.Json;

    public class ExceptionViewTest
    {
        [Fact]
        public void ExceptionView_RoundTrips_ThroughJsonSerialization()
        {
            var model = new ExceptionView
            {
                Message = "Something failed"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<ExceptionView>(json);

            Assert.NotNull(result);
            Assert.Equal(model.Message, result.Message);
        }
    }
}
