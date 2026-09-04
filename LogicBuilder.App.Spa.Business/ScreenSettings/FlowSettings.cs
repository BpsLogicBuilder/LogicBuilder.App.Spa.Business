using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
using LogicBuilder.App.Spa.Business.ScreenSettings.Views;

namespace LogicBuilder.App.Spa.Business.ScreenSettings
{
    public class FlowSettings(FlowState flowState, NavigationBar navigationBar, ScreenSettingsBase screenSettings)
    {
        public FlowState? FlowState { get; set; } = flowState;
        public NavigationBar? NavigationBar { get; set; } = navigationBar;
        public ScreenSettingsBase ScreenSettings { get; set; } = screenSettings;
    }
}
