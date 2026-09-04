using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.ScreenSettings
{
    public class FlowState
    {
        public string Driver { get; set; } = string.Empty;
        public string Selection { get; set; } = string.Empty;
        public List<string> CallingModuleDriverStack { get; set; } = [];
        public List<string> CallingModuleStack { get; set; } = [];
        public string ModuleBeginName { get; set; } = string.Empty;
        public string ModuleEndName { get; set; } = string.Empty;
    }
}
