namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using LogicBuilder.Domain;
    using System.Collections.Generic;
    using System.Text.Json;

    public class GridRequestTest
    {
        [Fact]
        public void GridRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new GridRequest
            {
                PersistentFlowItems = new Dictionary<string, object> { ["UserId"] = 1, ["UserName"] = "Smith101", ["UserRating"] = 9.5 },
                Entity = new TestModel { Id = 101, FirstName = "John" },
                ViewType = ViewType.Grid,
                CommandButtonRequest = new CommandButtonRequest
                {
                    NewSelection = "grid-row",
                    Cancel = true
                }
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<GridRequest>(json, SerializationOptions.Default);

            Assert.NotNull(result);
            Assert.NotNull(result.PersistentFlowItems);
            Assert.Equal((int)model.PersistentFlowItems["UserId"], (int)result.PersistentFlowItems["UserId"]);
            Assert.Equal((string)model.PersistentFlowItems["UserName"], (string)result.PersistentFlowItems["UserName"]);
            Assert.Equal((double)model.PersistentFlowItems["UserRating"], (double)result.PersistentFlowItems["UserRating"]);
            Assert.Equal(model.ViewType, result.ViewType);
            TestModel resultEntity = Assert.IsType<TestModel>(result.Entity, exactMatch: false);
            Assert.Equal(((TestModel)model.Entity).Id, resultEntity.Id);
            Assert.NotNull(result.CommandButtonRequest);
            Assert.Equal(model.CommandButtonRequest.Cancel, result.CommandButtonRequest.Cancel);
        }

        private class TestModel : BaseModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = "";
        }
    }
}
