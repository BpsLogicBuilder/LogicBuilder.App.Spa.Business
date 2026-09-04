using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Business.ScreenSettings.Views
{
    public enum ViewType
    {
        [AlsoKnownAs("ViewType.Grid")]
        Grid,
        [AlsoKnownAs("ViewType.Edit")]
        Edit,
        [AlsoKnownAs("ViewType.Create")]
        Create,
        [AlsoKnownAs("ViewType.Detail")]
        Detail,
        [AlsoKnownAs("ViewType.Delete")]
        Delete,
        [AlsoKnownAs("ViewType.Html")]
        Html,
        [AlsoKnownAs("ViewType.List")]
        List,
        [AlsoKnownAs("ViewType.FlowComplete")]
        FlowComplete,
        [AlsoKnownAs("ViewType.Exception")]
        Exception
    }
}
