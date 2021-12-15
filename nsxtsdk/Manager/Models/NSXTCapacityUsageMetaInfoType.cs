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

namespace nsxtsdk.ManagerModels
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
        [NSXTProperty(IsRequired: true, Description: @"Indicates the maximum global threshold percentage")]
        [System.ComponentModel.DataAnnotations.Required]
        public double MaxGlobalThresholdPercentage { get; set; }
        /// <summary>
        /// Indicates the minimum global threshold percentage
        /// </summary>
        [JsonProperty(PropertyName = "min_global_threshold_percentage", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Indicates the minimum global threshold percentage")]
        [System.ComponentModel.DataAnnotations.Required]
        public double MinGlobalThresholdPercentage { get; set; }
        /// <summary>
        /// Timestamp at which capacity usage was last calculated
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_timestamp", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Timestamp at which capacity usage was last calculated")]
        [System.ComponentModel.DataAnnotations.Required]
        public long LastUpdatedTimestamp { get; set; }
    }
}
