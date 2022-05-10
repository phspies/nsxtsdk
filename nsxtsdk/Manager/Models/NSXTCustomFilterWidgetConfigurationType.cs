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
    public class NSXTCustomFilterWidgetConfigurationType : NSXTFilterWidgetConfigurationType
    {
        /// <summary>
        /// User defined filter component selector to be rendered inside view/container.
        /// </summary>
        [JsonProperty(PropertyName = "ui_component_identifier", Required = Required.AllowNull)]
        public string UiComponentIdentifier { get; set; }
    }
}
