using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Business.Cache
{
    public class RequestedFlowStage
    {
        [AlsoKnownAs("RequestedFlowStage.InitialModule")]
        public string InitialModule { get; set; } = "";
        [AlsoKnownAs("RequestedFlowStage.TargetModule")]
        public int TargetModule { get; set; }
    }
}
