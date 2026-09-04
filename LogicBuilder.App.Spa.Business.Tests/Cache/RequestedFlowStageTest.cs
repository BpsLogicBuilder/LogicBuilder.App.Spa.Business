namespace LogicBuilder.App.Spa.Business.Tests.Cache
{
    using LogicBuilder.App.Spa.Business.Cache;
    using System.Text.Json;

    public class RequestedFlowStageTest
    {
        [Fact]
        public void RequestedFlowStage_RoundTrips_ThroughJsonSerialization()
        {
            var model = new RequestedFlowStage
            {
                InitialModule = "Initial",
                TargetModule = 9
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<RequestedFlowStage>(json);

            Assert.NotNull(result);
            Assert.Equal(model.InitialModule, result.InitialModule);
            Assert.Equal(model.TargetModule, result.TargetModule);
        }
    }
}
