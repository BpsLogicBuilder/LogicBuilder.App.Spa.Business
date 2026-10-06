namespace LogicBuilder.App.Spa.Business.Tests.ScreenSettings.Views
{
    using LogicBuilder.App.Spa.Business.ScreenSettings.Json;
    using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
    using LogicBuilder.Expressions.Utils.ExpressionDescriptors;
    using LogicBuilder.Expressions.Utils.Json;
    using System.Text.Json;

    public class ScreenSettingsTest
    {
        [Fact]
        public void ScreenSettings_RoundTrips_ThroughJsonSerialization()
        {
            var model = new ScreenSettings<string>("dialog", [], ViewType.Grid)
            {
                Settings = "updated-dialog"
            };

            var json = JsonSerializer.Serialize(model);
            var result = JsonSerializer.Deserialize<ScreenSettings<string>>(json);

            Assert.NotNull(result);
            Assert.Equal(model.ViewType, result.ViewType);
            Assert.Equal(model.Settings, result.Settings);
            Assert.Empty(result.CommandButtons ?? []);
        }

        [Fact]
        public void DescriptorConverterAccepts_DescriptorSubtypeFromRegisteredAssembly()
        {
            // Arrange
            JsonSerializerOptions options = new();
            options.Converters.Add(new ScreenSettingsConverter(typeof(ExternalScreenSettings).Assembly));
            string json = JsonSerializer.Serialize<ScreenSettingsBase>(new ExternalScreenSettings { Name = "A" }, options);

            // Act
            ScreenSettingsBase result = JsonSerializer.Deserialize<ScreenSettingsBase>(json, options)!;

            // Assert
            Assert.Equal("A", Assert.IsType<ExternalScreenSettings>(result).Name);
        }

        public class ExternalScreenSettings : ScreenSettingsBase
        {
            public int ID { get; set; }
            public string? Name { get; set; }

            public override ViewType ViewType => ViewType.Exception;
        }
    }
}
