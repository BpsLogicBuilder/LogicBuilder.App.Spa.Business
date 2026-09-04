namespace LogicBuilder.App.Spa.Business.Tests.Responses.TransientFlows
{
    using LogicBuilder.App.Spa.Business.Responses.TransientFlows;
    using System.Text.Json;

    public class SelectorFlowResponseTest
    {
        [Fact]
        public void SelectorFlowResponse_RoundTrips_ThroughJsonSerialization()
        {
            var model = new SelectorFlowResponse
            {
                Success = true,
                ErrorMessages = [],
                Selector = null
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<SelectorFlowResponse>(json);

            Assert.NotNull(result);
            Assert.Equal(model.Success, result.Success);
            Assert.Empty(result.ErrorMessages);
            Assert.Null(result.Selector);
        }
    }
}
