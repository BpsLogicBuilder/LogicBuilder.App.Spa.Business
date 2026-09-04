using LogicBuilder.App.Spa.Business.ScreenSettings.Json;
using LogicBuilder.App.Spa.Forms.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LogicBuilder.App.Spa.Business.ScreenSettings.Views
{
    [JsonConverter(typeof(ScreenSettingsConverter))]
    abstract public class ScreenSettingsBase
    {
        abstract public ViewType ViewType { get; }
        public IEnumerable<CommandButtonDescriptor>? CommandButtons { get; set; }
        public string TypeString => this.GetType().AssemblyQualifiedName ?? throw new ArgumentException($"{this.GetType().Name}: {{75FE4EA4-09BF-40C2-A750-50E46A801147}}");
    }
}
