namespace LogicBuilder.App.Spa.Business.Tests.Requests
{
    using LogicBuilder.App.Spa.Business.Requests;
    using LogicBuilder.App.Spa.Business.ScreenSettings;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using System.Collections.Generic;
    using System.Text.Json;

    public class DefaultRequestTest
    {
        [Fact]
        public void DefaultRequest_RoundTrips_ThroughJsonSerialization()
        {
            var model = new DefaultRequest
            {
                PersistentFlowItems = new Dictionary<string, object> { ["UserId"] = 1, ["UserName"] = "Smith101", ["UserRating"] = 9.5 },
                ViewType = ViewType.Edit,
                CommandButtonRequest = new CommandButtonRequest
                {
                    Cancel = false,
                    NewSelection = "row-1"
                },
                FlowState = new FlowState
                {
                    Driver = "DriverA",
                    Selection = "SelectionA",
                    CallingModuleDriverStack = ["D1"],
                    CallingModuleStack = ["M1"],
                    ModuleBeginName = "Begin",
                    ModuleEndName = "End"
                }
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<DefaultRequest>(json, SerializationOptions.Default);

            Assert.NotNull(result);
            Assert.NotNull(result.PersistentFlowItems);
            Assert.Equal((int)model.PersistentFlowItems["UserId"], (int)result.PersistentFlowItems["UserId"]);
            Assert.Equal((string)model.PersistentFlowItems["UserName"], (string)result.PersistentFlowItems["UserName"]);
            Assert.Equal((double)model.PersistentFlowItems["UserRating"], (double)result.PersistentFlowItems["UserRating"]);
            Assert.Equal(model.ViewType, result.ViewType);
            Assert.NotNull(result.CommandButtonRequest);
            Assert.Equal(model.CommandButtonRequest.NewSelection, result.CommandButtonRequest.NewSelection);
            Assert.NotNull(result.FlowState);
            Assert.Equal(model.FlowState.Driver, result.FlowState.Driver);
        }
    }
}
