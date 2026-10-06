using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using LogicBuilder.Expressions.Utils.Json;
using System.Linq;
using System.Reflection;

namespace LogicBuilder.App.Spa.Business.ScreenSettings.Json
{
    public class ScreenSettingsConverter : JsonTypeConverter<ScreenSettingsBase>
    {
        /// <summary>
        /// Allows only the descriptors defined in LogicBuilder.Structures.
        /// Used when the converter is applied through the <see cref="System.Text.Json.Serialization.JsonConverterAttribute"/> on <see cref="ScreenSettingsBase"/>.
        /// </summary>
        public ScreenSettingsConverter()
        {
        }

        /// <summary>
        /// Allows the descriptors defined in LogicBuilder.Structures plus concrete <see cref="ScreenSettingsBase"/> subtypes defined in <paramref name="additionalAssemblies"/>.
        /// Register with <see cref="System.Text.Json.JsonSerializerOptions.Converters"/> - converters added to the options take precedence over the attribute on <see cref="ScreenSettingsBase"/>.
        /// </summary>
        public ScreenSettingsConverter(params Assembly[] additionalAssemblies)
            : base(new[] { typeof(ScreenSettingsBase).Assembly }.Concat(additionalAssemblies ?? []))
        {
        }

        public override string TypePropertyName => nameof(ScreenSettingsBase.TypeString);
    }
}
