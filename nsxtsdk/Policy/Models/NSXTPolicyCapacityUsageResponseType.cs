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
    public class NSXTPolicyCapacityUsageResponseType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of capacity usage for NSX Objects
        /// </summary>
        [JsonProperty(PropertyName = "capacity_usage", Required = Required.AllowNull)]
        public IList<NSXTPolicyCapacityDashboardUsageType> CapacityUsage { get; set; }
    }
}
