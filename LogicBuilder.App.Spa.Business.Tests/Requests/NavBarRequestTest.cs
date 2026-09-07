namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using System.Collections.Generic;
    using System.Text.Json;

    public class NavBarRequestTest
    {
        [Fact]
        public void NavBarRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new NavBarRequest
            {
                PersistentFlowItems = new Dictionary<string, object> { ["UserId"] = 1, ["UserName"] = "Smith101", ["UserRating"] = 9.5 },
                InitialModuleName = "Home",
                TargetModule = 4
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<NavBarRequest>(json, SerializationOptions.Default);

            Assert.NotNull(result);
            Assert.NotNull(result.PersistentFlowItems);
            Assert.Equal((int)model.PersistentFlowItems["UserId"], (int)result.PersistentFlowItems["UserId"]);
            Assert.Equal((string)model.PersistentFlowItems["UserName"], (string)result.PersistentFlowItems["UserName"]);
            Assert.Equal((double)model.PersistentFlowItems["UserRating"], (double)result.PersistentFlowItems["UserRating"]);
            Assert.Equal(model.InitialModuleName, result.InitialModuleName);
            Assert.Equal(model.TargetModule, result.TargetModule);
        }
    }
}
