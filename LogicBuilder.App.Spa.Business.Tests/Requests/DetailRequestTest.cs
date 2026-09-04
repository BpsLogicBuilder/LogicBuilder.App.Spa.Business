namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Text.Json;

    public class DetailRequestTest
    {
        [Fact]
        public void DetailRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new DetailRequest
            {
                Entity = null,
                ViewType = ViewType.Detail,
                CommandButtonRequest = new CommandButtonRequest
                {
                    NewSelection = "next",
                    Cancel = false
                }
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<DetailRequest>(json);

            Assert.NotNull(result);
            Assert.Equal(model.ViewType, result.ViewType);
            Assert.Null(result.Entity);
            Assert.NotNull(result.CommandButtonRequest);
            Assert.Equal(model.CommandButtonRequest.NewSelection, result.CommandButtonRequest.NewSelection);
        }
    }
}
