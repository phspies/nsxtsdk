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
    public class NSXTEdgeClusterMemberInterSiteStatusType 
    {
        public NSXTEdgeClusterMemberInterSiteStatusType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// Total number of current established inter-site IBGP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "established_bgp_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of current established inter-site IBGP sessions.")]
        public long? EstablishedBgpSessions { get; set; }
        /// <summary>
        /// Edge node IBGP status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Edge node IBGP status")]
        public NSXTEdgeClusterMemberInterSiteStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Total number of inter-site IBGP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "total_bgp_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of inter-site IBGP sessions.")]
        public long? TotalBgpSessions { get; set; }
        /// <summary>
        /// Inter-site BGP neighbor status.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status")]
        [NSXTProperty(IsRequired: false, Description: @"Inter-site BGP neighbor status.")]
        public IList<NSXTBgpNeighborStatusLiteDtoType> NeighborStatus { get; set; }
    }
}
