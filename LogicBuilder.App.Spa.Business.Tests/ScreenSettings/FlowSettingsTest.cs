namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings
{
    using LogicBuilder.App.Spa.Business.ScreenSettings;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Collections.Generic;
    using System.Text.Json;

    public class FlowSettingsTest
    {
        [Fact]
        public void FlowSettings_RoundTrips_ThroughJsonSerialization()
        {
            var model = new FlowSettings
            (
                new Dictionary<string, object> { ["UserId"] = 1, ["UserName"] = "Smith101", ["UserRating"] = 9.5 },
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
                new ScreenSettings<string>("dialog-settings", [], ViewType.Detail)
            );

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<FlowSettings>(json, SerializationOptions.Default);

            Assert.NotNull(result);
            Assert.NotNull(result.PersistentFlowItems);
            Assert.Equal((int)model.PersistentFlowItems["UserId"], (int)result.PersistentFlowItems["UserId"]);
            Assert.Equal((string)model.PersistentFlowItems["UserName"], (string)result.PersistentFlowItems["UserName"]);
            Assert.Equal((double)model.PersistentFlowItems["UserRating"], (double)result.PersistentFlowItems["UserRating"]);
            Assert.NotNull(result.FlowState);
            Assert.Equal(model.FlowState!.Driver, result.FlowState.Driver);
            Assert.NotNull(result.NavigationBar);
            Assert.Equal(model.NavigationBar!.BrandText, result.NavigationBar.BrandText);
            Assert.IsType<ScreenSettings<string>>(result.ScreenSettings);
        }
    }
}
