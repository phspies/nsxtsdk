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
    public class NSXTInterSiteBgpSummaryType 
    {
        /// <summary>
        /// Timestamp when the inter-site IBgp neighbors status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Status of all inter-site IBgp neighbors.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        public IList<NSXTBgpNeighborStatusType> NeighborStatus { get; set; }
        /// <summary>
        /// Edge node id whose status is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
