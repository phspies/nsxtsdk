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
    /// Static filters
    /// </summary>
    [NSXTProperty(Description: @"Static filters")]
    public class NSXTStaticFilterType 
    {
        /// <summary>
        /// Property value is shown in the drop down input box for a filter. If the value is not provided 'display_name' property
        /// value is used.
        /// </summary>
        [JsonProperty(PropertyName = "short_display_name")]
        public string? ShortDisplayName { get; set; }
        /// <summary>
        /// display name to be shown in the drop down for static filter.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// An additional key-value pair for static filter.
        /// </summary>
        [JsonProperty(PropertyName = "additional_value")]
        public object? AdditionalValue { get; set; }
        /// <summary>
        /// Value of static filter inside dropdown filter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
