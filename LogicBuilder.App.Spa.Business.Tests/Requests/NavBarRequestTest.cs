namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using System.Text.Json;

    public class NavBarRequestTest
    {
        [Fact]
        public void NavBarRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new NavBarRequest
            {
                InitialModuleName = "Home",
                TargetModule = 4
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<NavBarRequest>(json);

            Assert.NotNull(result);
            Assert.Equal(model.InitialModuleName, result.InitialModuleName);
            Assert.Equal(model.TargetModule, result.TargetModule);
            Assert.Empty(result.PersistentFlowItems);
        }
    }
}
