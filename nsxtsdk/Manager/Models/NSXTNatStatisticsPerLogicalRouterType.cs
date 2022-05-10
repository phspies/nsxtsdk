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
    public class NSXTNatStatisticsPerLogicalRouterType 
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Detailed per node statistics
        /// </summary>
        [JsonProperty(PropertyName = "per_transport_node_statistics")]
        public IList<NSXTNatStatisticsPerTransportNodeType> PerTransportNodeStatistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics_across_all_nodes")]
        public NSXTNatCountersType StatisticsAcrossAllNodes { get; set; }
        /// <summary>
        /// Id for the logical router
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
    }
}
