namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings.Navigation
{
    using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
    using System.Text.Json;

    public class NavigationBarTest
    {
        [Fact]
        public void NavigationBar_RoundTrips_ThroughJsonSerialization()
        {
            var model = new NavigationBar
            {
                BrandText = "App Brand",
                CurrentModule = 7,
                MenuItems =
                [
                    new NavigationMenuItem(2, "Initial", "Menu")
                    {
                        Active = true
                    }
                ]
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<NavigationBar>(json);

            Assert.NotNull(result);
            Assert.Equal(model.BrandText, result.BrandText);
            Assert.Equal(model.CurrentModule, result.CurrentModule);
            Assert.Single(result.MenuItems);
            Assert.True(result.MenuItems[0].Active);
        }
    }
}
