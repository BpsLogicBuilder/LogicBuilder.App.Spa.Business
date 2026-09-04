namespace LogicBuilder.App.Spa.Business.Tests.Responses.TransientFlows
{
    using LogicBuilder.App.Spa.Business.Responses.TransientFlows;
    using System.Text.Json;

    public class ErrorFlowResponseTest
    {
        [Fact]
        public void ErrorFlowResponse_RoundTrips_ThroughJsonSerialization()
        {
            var model = new ErrorFlowResponse
            {
                Success = false,
                ErrorMessages = ["error-1", "error-2"]
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<ErrorFlowResponse>(json);

            Assert.NotNull(result);
            Assert.Equal(model.Success, result.Success);
            Assert.Equal(model.ErrorMessages, result.ErrorMessages);
        }
    }
}
