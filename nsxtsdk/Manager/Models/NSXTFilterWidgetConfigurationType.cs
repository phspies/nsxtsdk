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
    public class NSXTFilterWidgetConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Alias to be used when emitting filter value.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string? Alias { get; set; }
    }
}
