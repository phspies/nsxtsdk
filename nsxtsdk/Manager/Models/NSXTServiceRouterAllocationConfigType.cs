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
    public class NSXTServiceRouterAllocationConfigType 
    {
        /// <summary>
        /// For TIER 1 logical router, for manual placement of service router
        /// within the cluster, edge cluster member indices needs to be provided
        /// else same will be auto-allocated. You can provide maximum two indices
        /// for HA ACTIVE_STANDBY.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indices")]
        public long? EdgeClusterMemberIndices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "allocation_pool")]
        public NSXTEdgeClusterMemberAllocationPoolType AllocationPool { get; set; }
        /// <summary>
        /// To reallocate TIER1 logical router on new or existing edge cluster
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        public string EdgeClusterId { get; set; }
    }
}
