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
    /// Allocation details of cluster and its members. Contains information of the
        /// edge nodes present in cluster, active and standby services of each node,
        /// utilization details of configured sub-pools. These allocation details can
        /// be monitored by customers to trigger migration of certain service contexts
        /// to different edge nodes, to balance the utilization of edge node resources.
    /// </summary>
    [NSXTProperty(Description: @"Allocation details of cluster and its members. Contains information of theedge nodes present in cluster, active and standby services of each node,utilization details of configured sub-pools. These allocation details canbe monitored by customers to trigger migration of certain service contextsto different edge nodes, to balance the utilization of edge node resources.")]
    public class NSXTEdgeClusterAllocationStatusType 
    {
        /// <summary>
        /// Allocation details of edge nodes present in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTEdgeMemberAllocationStatusType> Members { get; set; }
        /// <summary>
        /// Display name of the edge cluster
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// System allotted UUID of edge cluster.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Represents the number of edge nodes in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        public int? MemberCount { get; set; }
    }
}
