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
    public class NSXTPolicyEdgeNodeInterSiteBgpSummaryType 
    {
        /// <summary>
        /// Timestamp when the inter-site IBGP neighbors status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Status of all inter-site IBGP neighbors.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        public IList<NSXTPolicyBgpNeighborStatusType> NeighborStatus { get; set; }
        /// <summary>
        /// Edge node path whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_path")]
        public string? EdgeNodePath { get; set; }
    }
}
