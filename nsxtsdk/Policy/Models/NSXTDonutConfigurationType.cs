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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDonutConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Expression to retrieve count to be shown on Donut.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public string? Count { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// If true, displays the count of entities in the donut
        /// </summary>
        [JsonProperty(PropertyName = "display_count")]
        public bool? DisplayCount { get; set; }
        /// <summary>
        /// Sections
        /// </summary>
        [JsonProperty(PropertyName = "sections", Required = Required.AllowNull)]
        public IList<NSXTDonutSectionType> Sections { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
    }
}
