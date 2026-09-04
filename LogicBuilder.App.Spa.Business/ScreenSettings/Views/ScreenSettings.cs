using LogicBuilder.App.Spa.Forms.Configuration;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Business.ScreenSettings.Views
{
    public class ScreenSettings<TDialogSetting> : ScreenSettingsBase
    {
        public ScreenSettings(TDialogSetting settings, IEnumerable<CommandButtonDescriptor> commandButtons, ViewType viewType)
        {
            Settings = settings;
            CommandButtons = commandButtons;
            this.ViewType = viewType;
        }

        public override ViewType ViewType { get; }
        public TDialogSetting Settings { get; set; }
    }
}
