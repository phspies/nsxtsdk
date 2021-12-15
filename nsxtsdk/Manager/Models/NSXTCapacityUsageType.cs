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
    public class NSXTCapacityUsageType : NSXTResourceType
    {
        /// <summary>
        /// count of number of items of capacity_type
        /// </summary>
        [JsonProperty(PropertyName = "usage_count")]
        [NSXTProperty(IsRequired: false, Description: @"count of number of items of capacity_type")]
        public long? UsageCount { get; set; }
        /// <summary>
        /// type of the capacity field
        /// </summary>
        [JsonProperty(PropertyName = "capacity_type")]
        [NSXTProperty(IsRequired: false, Description: @"type of the capacity field")]
        public string? CapacityType { get; set; }
    }
}