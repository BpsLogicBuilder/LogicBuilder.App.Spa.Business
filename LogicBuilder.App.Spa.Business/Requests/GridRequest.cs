using LogicBuilder.App.Spa.Business.ScreenSettings.Views;
using LogicBuilder.Domain;

namespace LogicBuilder.App.Spa.Business.Requests
{
    public class GridRequest : RequestBase
    {
        public BaseModel? Entity { get; set; }
        public override ViewType ViewType { get; set; }
    }
}
