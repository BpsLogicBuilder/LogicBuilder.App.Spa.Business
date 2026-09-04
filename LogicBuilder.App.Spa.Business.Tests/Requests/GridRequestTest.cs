namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Text.Json;

    public class GridRequestTest
    {
        [Fact]
        public void GridRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new GridRequest
            {
                Entity = null,
                ViewType = ViewType.Grid,
                CommandButtonRequest = new CommandButtonRequest
                {
                    NewSelection = "grid-row",
                    Cancel = true
                }
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<GridRequest>(json);

            Assert.NotNull(result);
            Assert.Equal(model.ViewType, result.ViewType);
            Assert.Null(result.Entity);
            Assert.NotNull(result.CommandButtonRequest);
            Assert.Equal(model.CommandButtonRequest.Cancel, result.CommandButtonRequest.Cancel);
        }
    }
}
