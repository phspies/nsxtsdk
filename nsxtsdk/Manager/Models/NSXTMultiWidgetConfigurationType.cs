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
    public class NSXTMultiWidgetConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Array of widgets that are part of the multi-widget.
        /// </summary>
        [JsonProperty(PropertyName = "widgets", Required = Required.AllowNull)]
        public IList<NSXTWidgetItemType> Widgets { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
    }
}
