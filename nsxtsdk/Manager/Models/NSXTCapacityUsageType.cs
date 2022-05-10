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
    public class NSXTCapacityUsageType : NSXTResourceType
    {
        /// <summary>
        /// count of number of items of capacity_type
        /// </summary>
        [JsonProperty(PropertyName = "usage_count")]
        public long? UsageCount { get; set; }
        /// <summary>
        /// type of the capacity field
        /// </summary>
        [JsonProperty(PropertyName = "capacity_type")]
        public string? CapacityType { get; set; }
    }
}
