namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings.Navigation
{
    using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
    using System.Text.Json;

    public class NavigationMenuItemTest
    {
        [Fact]
        public void NavigationMenuItem_RoundTrips_ThroughJsonSerialization()
        {
            var model = new NavigationMenuItem(3, "Start", "Item")
            {
                Active = true,
                SubItems =
                [
                    new NavigationMenuItem(4, "SubStart", "SubItem")
                ]
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<NavigationMenuItem>(json);

            Assert.NotNull(result);
            Assert.Equal(model.TargetModule, result.TargetModule);
            Assert.Equal(model.InitialModule, result.InitialModule);
            Assert.Equal(model.Text, result.Text);
            Assert.True(result.Active);
            Assert.Single(result.SubItems);
        }
    }
}
