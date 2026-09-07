namespace LogicBuilder.App.Spa.Business.Tests.Requests.TransientFlows
{
    using LogicBuilder.App.Spa.Business.Requests.TransientFlows;
    using LogicBuilder.Domain;
    using System.Text.Json;

    public class SelectorFlowRequestTest
    {
        [Fact]
        public void SelectorFlowRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new SelectorFlowRequest
            {
                Entity =new TestModel { Id = 101, FirstName = "John" },
                ReloadItemsFlowName = "ReloadFlow"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<SelectorFlowRequest>(json, SerializationOptions.Default);

            Assert.NotNull(result);
            Assert.NotNull(result.Entity);
            TestModel resultEntity = Assert.IsType<TestModel>(result.Entity, exactMatch: false);
            Assert.Equal(((TestModel)model.Entity).Id, resultEntity.Id);
            Assert.Equal(((TestModel)model.Entity).FirstName, resultEntity.FirstName);
            Assert.Equal(model.ReloadItemsFlowName, result.ReloadItemsFlowName);
        }

        private class TestModel : BaseModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = "";
        }
    }
}
