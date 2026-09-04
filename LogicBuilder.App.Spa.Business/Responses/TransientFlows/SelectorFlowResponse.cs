using LogicBuilder.Expressions.Utils.ExpressionDescriptors;

namespace LogicBuilder.App.Spa.Business.Responses.TransientFlows
{
    public class SelectorFlowResponse : BaseFlowResponse
    {
        public SelectorLambdaDescriptor? Selector { get; set; }
    }
}
