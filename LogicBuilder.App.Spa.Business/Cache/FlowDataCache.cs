using LogicBuilder.App.Spa.Business.Cache.Interfaces;
using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.Cache
{
    public class FlowDataCache : IFlowDataCache
    {
        public Dictionary<string, object> Items { get; set; } = [];
        public NavigationBar NavigationBar { get; set; } = new NavigationBar();
        public List<string> PersistentKeys { get; set; } = [];
        public RequestedFlowStage RequestedFlowStage { get; set; } = new RequestedFlowStage();
        public ScreenSettingsBase? ScreenSettings { get; set; }
    }
}
