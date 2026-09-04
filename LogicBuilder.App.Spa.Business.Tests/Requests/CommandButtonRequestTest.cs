namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using System.Text.Json;

    public class CommandButtonRequestTest
    {
        [Fact]
        public void CommandButtonRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new CommandButtonRequest
            {
                NewSelection = "new-selection",
                Cancel = true
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<CommandButtonRequest>(json);

            Assert.NotNull(result);
            Assert.Equal(model.NewSelection, result.NewSelection);
            Assert.Equal(model.Cancel, result.Cancel);
        }
    }
}
