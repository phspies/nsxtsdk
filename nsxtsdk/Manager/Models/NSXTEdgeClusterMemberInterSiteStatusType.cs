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
    public class NSXTEdgeClusterMemberInterSiteStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        public NSXTResourceReferenceType TransportNode { get; set; }
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
        public NSXTEdgeClusterMemberInterSiteStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Total number of inter-site IBGP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "total_bgp_sessions")]
        public long? TotalBgpSessions { get; set; }
        /// <summary>
        /// Inter-site BGP neighbor status.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        public IList<NSXTBgpNeighborStatusLiteDtoType> NeighborStatus { get; set; }
    }
}
