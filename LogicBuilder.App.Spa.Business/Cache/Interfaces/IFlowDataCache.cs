using LogicBuilder.App.Spa.Business.ScreenSettings.Navigation;
using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.Cache.Interfaces
{
    public interface IFlowDataCache
    {
        Dictionary<string, object> Items { get; set; }
        NavigationBar NavigationBar { get; set; }
        List<string> PersistentKeys { get; set; }
        RequestedFlowStage RequestedFlowStage { get; set; }
        ScreenSettingsBase? ScreenSettings { get; set; }
    }
}
