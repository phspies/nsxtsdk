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
    public class NSXTPolicyEdgeClusterMemberInterSiteStatusType 
    {
        /// <summary>
        /// Total number of current established inter-site IBGP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "established_bgp_sessions")]
        public long? EstablishedBgpSessions { get; set; }
        /// <summary>
        /// Edge node IBGP status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyEdgeClusterMemberInterSiteStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Inter-site BGP neighbor status.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        public IList<NSXTPolicyBgpNeighborStatusType> NeighborStatus { get; set; }
        /// <summary>
        /// Total number of inter-site IBGP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "total_bgp_sessions")]
        public long? TotalBgpSessions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_path")]
        public NSXTResourceReferenceType EdgeNodePath { get; set; }
    }
}
