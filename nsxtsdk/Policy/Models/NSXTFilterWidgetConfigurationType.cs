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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFilterWidgetConfigurationType : NSXTWidgetConfigurationType
    {
        public NSXTFilterWidgetConfigurationType()
        {
        }
        /// <summary>
        /// Alias to be used when emitting filter value.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        [NSXTProperty(IsRequired: false, Description: @"Alias to be used when emitting filter value.")]
        public string? Alias { get; set; }
    }
}
