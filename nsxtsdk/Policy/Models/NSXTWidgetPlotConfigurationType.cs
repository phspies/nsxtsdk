using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Base type for widget plot config.
    /// </summary>
    [NSXTProperty(Description: @"Base type for widget plot config.")]
    public class NSXTWidgetPlotConfigurationType 
    {
        /// <summary>
        /// Allow maximize capability for this widget
        /// </summary>
        [JsonProperty(PropertyName = "allow_maximize")]
        public bool? AllowMaximize { get; set; }
        /// <summary>
        /// If the condition is met then the given chart config is applied to the widget configuration.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
    }
}
