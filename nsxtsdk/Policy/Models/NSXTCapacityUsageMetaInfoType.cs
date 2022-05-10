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
    public class NSXTCapacityUsageMetaInfoType 
    {
        /// <summary>
        /// Indicates the maximum global threshold percentage
        /// </summary>
        [JsonProperty(PropertyName = "max_global_threshold_percentage", Required = Required.AllowNull)]
        public double MaxGlobalThresholdPercentage { get; set; }
        /// <summary>
        /// Indicates the minimum global threshold percentage
        /// </summary>
        [JsonProperty(PropertyName = "min_global_threshold_percentage", Required = Required.AllowNull)]
        public double MinGlobalThresholdPercentage { get; set; }
        /// <summary>
        /// Timestamp at which capacity usage was last calculated
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_timestamp", Required = Required.AllowNull)]
        public long LastUpdatedTimestamp { get; set; }
    }
}
