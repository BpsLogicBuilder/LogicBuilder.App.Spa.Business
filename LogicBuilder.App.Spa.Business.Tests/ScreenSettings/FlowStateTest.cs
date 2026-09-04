namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings
{
    using LogicBuilder.App.Spa.Business.ScreenSettings;
    using System.Text.Json;

    public class FlowStateTest
    {
        [Fact]
        public void FlowState_RoundTrips_ThroughJsonSerialization()
        {
            var model = new FlowState
            {
                Driver = "DriverA",
                Selection = "SelectionA",
                CallingModuleDriverStack = ["Driver1", "Driver2"],
                CallingModuleStack = ["Module1", "Module2"],
                ModuleBeginName = "Begin",
                ModuleEndName = "End"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<FlowState>(json);

            Assert.NotNull(result);
            Assert.Equal(model.Driver, result.Driver);
            Assert.Equal(model.Selection, result.Selection);
            Assert.Equal(model.CallingModuleDriverStack, result.CallingModuleDriverStack);
            Assert.Equal(model.CallingModuleStack, result.CallingModuleStack);
            Assert.Equal(model.ModuleBeginName, result.ModuleBeginName);
            Assert.Equal(model.ModuleEndName, result.ModuleEndName);
        }
    }
}
