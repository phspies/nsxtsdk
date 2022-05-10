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
    /// Represents a list of widget configurations.
    /// </summary>
    [NSXTProperty(Description: @"Represents a list of widget configurations.")]
    public class NSXTWidgetConfigurationListType 
    {
        /// <summary>
        /// Array of widget configurations
        /// </summary>
        [JsonProperty(PropertyName = "widgetconfigurations")]
        public IList<NSXTWidgetConfigurationType> Widgetconfigurations { get; set; }
    }
}
