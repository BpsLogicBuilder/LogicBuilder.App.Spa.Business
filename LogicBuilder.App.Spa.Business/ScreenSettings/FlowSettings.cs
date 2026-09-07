using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.ScreenSettings
{
    public class FlowSettings(Dictionary<string, object> persistentFlowItems, FlowState flowState, NavigationBar navigationBar, ScreenSettingsBase screenSettings)
    {
        public Dictionary<string, object> PersistentFlowItems { get; set; } = persistentFlowItems;
        public FlowState FlowState { get; set; } = flowState;
        public NavigationBar NavigationBar { get; set; } = navigationBar;
        public ScreenSettingsBase ScreenSettings { get; set; } = screenSettings;
    }
}
