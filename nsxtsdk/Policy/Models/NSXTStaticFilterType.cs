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
    /// Static filters
    /// </summary>
    [NSXTProperty(Description: @"Static filters")]
    public class NSXTStaticFilterType 
    {
        /// <summary>
        /// display name to be shown in the drop down for static filter.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"display name to be shown in the drop down for static filter.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Value of static filter inside dropdown filter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [NSXTProperty(IsRequired: false, Description: @"Value of static filter inside dropdown filter.")]
        public string? Value { get; set; }
    }
}
