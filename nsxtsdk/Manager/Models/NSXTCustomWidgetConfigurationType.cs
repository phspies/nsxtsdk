// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"User defined component selector to be rendered inside view/container.")]
        public string? UiComponentIdentifier { get; set; }
    }
}