namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings
{
    using LogicBuilder.App.Spa.Business.ScreenSettings;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Text.Json;

    public class FlowSettingsTest
    {
        [Fact]
        public void FlowSettings_RoundTrips_ThroughJsonSerialization()
        {
            var model = new FlowSettings
            (
                new FlowState
                {
                    Driver = "Driver",
                    Selection = "Selection",
                    ModuleBeginName = "Begin",
                    ModuleEndName = "End"
                },
                new NavigationBar
                {
                    BrandText = "Brand",
                    CurrentModule = 2
                },
                new LogicBuilder.App.Spa.Business.ScreenSettings.Views.ScreenSettings<string>("dialog-settings", [], ViewType.Detail)
            );

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<FlowSettings>(json);

            Assert.NotNull(result);
            Assert.NotNull(result.FlowState);
            Assert.Equal(model.FlowState!.Driver, result.FlowState.Driver);
            Assert.NotNull(result.NavigationBar);
            Assert.Equal(model.NavigationBar!.BrandText, result.NavigationBar.BrandText);
            Assert.IsType<ScreenSettings<string>>(result.ScreenSettings);
        }
    }
}
