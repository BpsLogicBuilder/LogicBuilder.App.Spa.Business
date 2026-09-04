namespace LogicBuilder.App.Spa.Business.Tests.Requests.TransientFlows
{
    using LogicBuilder.App.Spa.Business.Requests.TransientFlows;
    using System.Text.Json;

    public class SelectorFlowRequestTest
    {
        [Fact]
        public void SelectorFlowRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new SelectorFlowRequest
            {
                Entity = null,
                ReloadItemsFlowName = "ReloadFlow"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<SelectorFlowRequest>(json);

            Assert.NotNull(result);
            Assert.Null(result.Entity);
            Assert.Equal(model.ReloadItemsFlowName, result.ReloadItemsFlowName);
        }
    }
}
