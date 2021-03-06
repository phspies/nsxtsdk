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
    public class NSXTPolicyCapacityDashboardUsageType 
    {
        /// <summary>
        /// Indicate the current usage count of object type.
        /// </summary>
        [JsonProperty(PropertyName = "current_usage_count", Required = Required.AllowNull)]
        public long CurrentUsageCount { get; set; }
        /// <summary>
        /// Indicate the object type for which usage is calculated.
        /// </summary>
        [JsonProperty(PropertyName = "usage_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyCapacityDashboardUsageUsageTypeEnumType UsageType { get; set; }
        /// <summary>
        /// Display name for NSX object type.
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Current usage percentage for object type
        /// </summary>
        [JsonProperty(PropertyName = "current_usage_percentage", Required = Required.AllowNull)]
        public double CurrentUsagePercentage { get; set; }
        /// <summary>
        /// This is the maximum supported count for object type in consideration.
        /// </summary>
        [JsonProperty(PropertyName = "max_supported_count", Required = Required.AllowNull)]
        public long MaxSupportedCount { get; set; }
    }
}
