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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTHeatMapTransportZoneStatusType 
    {
        public NSXTHeatMapTransportZoneStatusType()
        {
        }
        /// <summary>
        /// Number of transport nodes that are degraded
        /// </summary>
        [JsonProperty(PropertyName = "degraded_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of transport nodes that are degraded")]
        public int? DegradedCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are down
        /// </summary>
        [JsonProperty(PropertyName = "down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of transport nodes that are down")]
        public int? DownCount { get; set; }
        /// <summary>
        /// Number of transport nodes with unknown status
        /// </summary>
        [JsonProperty(PropertyName = "unknown_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of transport nodes with unknown status")]
        public int? UnknownCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are up
        /// </summary>
        [JsonProperty(PropertyName = "up_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of transport nodes that are up")]
        public int? UpCount { get; set; }
    }
}
