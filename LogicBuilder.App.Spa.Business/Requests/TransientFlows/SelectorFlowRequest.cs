using LogicBuilder.Domain;

namespace LogicBuilder.App.Spa.Business.Requests.TransientFlows
{
    public class SelectorFlowRequest
    {
        public BaseModel? Entity { get; set; }
        public string? ReloadItemsFlowName { get; set; }
    }
}
