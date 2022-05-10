using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCustomWidgetConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// User defined component selector to be rendered inside view/container.
        /// </summary>
        [JsonProperty(PropertyName = "ui_component_identifier")]
        public string? UiComponentIdentifier { get; set; }
    }
}
