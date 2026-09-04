namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings.Views
{
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Text.Json;

    public class ScreenSettingsTest
    {
        [Fact]
        public void ScreenSettings_RoundTrips_ThroughJsonSerialization()
        {
            var model = new ScreenSettings<string>("dialog", [], ViewType.Grid)
            {
                Settings = "updated-dialog"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<ScreenSettings<string>>(json);

            Assert.NotNull(result);
            Assert.Equal(model.ViewType, result.ViewType);
            Assert.Equal(model.Settings, result.Settings);
            Assert.Empty(result.CommandButtons ?? []);
        }
    }
}
