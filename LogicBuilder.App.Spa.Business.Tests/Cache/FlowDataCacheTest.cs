namespace LogicBuilder.App.Spa.Business.Tests.Cache
{
    using LogicBuilder.App.Spa.Business.Cache;
    using System.Text.Json;

    public class FlowDataCacheTest
    {
        [Fact]
        public void FlowDataCache_RoundTrips_ThroughJsonSerialization()
        {
            var model = new FlowDataCache
            {
                PersistentKeys = ["key1", "key2"],
                RequestedFlowStage = new RequestedFlowStage
                {
                    InitialModule = "Start",
                    TargetModule = 3
                },
                ScreenSettings = null
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<FlowDataCache>(json);

            Assert.NotNull(result);
            Assert.Equal(model.PersistentKeys, result.PersistentKeys);
            Assert.Equal(model.RequestedFlowStage.InitialModule, result.RequestedFlowStage.InitialModule);
            Assert.Equal(model.RequestedFlowStage.TargetModule, result.RequestedFlowStage.TargetModule);
            Assert.Null(result.ScreenSettings);
        }
    }
}
