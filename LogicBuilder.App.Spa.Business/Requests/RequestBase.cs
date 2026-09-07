using LogicBuilder.App.Spa.Business.Requests.Json;
using LogicBuilder.App.Spa.Business.ScreenSettings;
using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LogicBuilder.App.Spa.Business.Requests
{
    [JsonConverter(typeof(RequestConverter))]
    abstract public class RequestBase
    {
        public Dictionary<string, object> PersistentFlowItems { get; set; } = [];
        public CommandButtonRequest? CommandButtonRequest { get; set; }
        public FlowState? FlowState { get; set; }
        abstract public ViewType ViewType { get; set; }
    }
}
