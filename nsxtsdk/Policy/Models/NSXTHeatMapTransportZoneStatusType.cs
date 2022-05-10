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
    public class NSXTHeatMapTransportZoneStatusType 
    {
        /// <summary>
        /// Number of transport nodes that are degraded
        /// </summary>
        [JsonProperty(PropertyName = "degraded_count")]
        public int? DegradedCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are down
        /// </summary>
        [JsonProperty(PropertyName = "down_count")]
        public int? DownCount { get; set; }
        /// <summary>
        /// Number of transport nodes with unknown status
        /// </summary>
        [JsonProperty(PropertyName = "unknown_count")]
        public int? UnknownCount { get; set; }
        /// <summary>
        /// Number of transport nodes that are up
        /// </summary>
        [JsonProperty(PropertyName = "up_count")]
        public int? UpCount { get; set; }
    }
}
