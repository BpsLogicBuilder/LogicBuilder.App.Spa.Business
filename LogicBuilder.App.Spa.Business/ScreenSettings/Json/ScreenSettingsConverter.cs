using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using LogicBuilder.Expressions.Utils.Json;

namespace LogicBuilder.App.Spa.Business.ScreenSettings.Json
{
    public class ScreenSettingsConverter : JsonTypeConverter<ScreenSettingsBase>
    {
        public override string TypePropertyName => nameof(ScreenSettingsBase.TypeString);
    }
}
