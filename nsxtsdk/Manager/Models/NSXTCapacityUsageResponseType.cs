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
    public class NSXTCapacityUsageResponseType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of capacity usage for NSX Objects
        /// </summary>
        [JsonProperty(PropertyName = "capacity_usage", Required = Required.AllowNull)]
        public IList<NSXTCapacityDashboardUsageType> CapacityUsage { get; set; }
        /// <summary>
        /// Meta data for capacity usage statistics
        /// </summary>
        [JsonProperty(PropertyName = "meta_info", Required = Required.AllowNull)]
        public object MetaInfo { get; set; }
        /// <summary>
        /// Types for which usage data was not reported
        /// </summary>
        [JsonProperty(PropertyName = "unreported_usage_types")]
        public IList<string> UnreportedUsageTypes { get; set; }
    }
}
