using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.Requests
{
    public class NavBarRequest
    {
        public Dictionary<string, object> PersistentFlowItems { get; set; } = [];
        public string? InitialModuleName { get; set; }
        public int TargetModule { get; set; }
    }
}
