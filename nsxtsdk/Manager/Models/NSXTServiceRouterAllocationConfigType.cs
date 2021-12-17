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
    public class NSXTServiceRouterAllocationConfigType 
    {
        public NSXTServiceRouterAllocationConfigType()
        {
        }
        /// <summary>
        /// For TIER 1 logical router, for manual placement of service router
        /// within the cluster, edge cluster member indices needs to be provided
        /// else same will be auto-allocated. You can provide maximum two indices
        /// for HA ACTIVE_STANDBY.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indices")]
        [NSXTProperty(IsRequired: false, Description: @"For TIER 1 logical router, for manual placement of service routerwithin the cluster, edge cluster member indices needs to be providedelse same will be auto-allocated. You can provide maximum two indicesfor HA ACTIVE_STANDBY.")]
        public long? EdgeClusterMemberIndices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "allocation_pool")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTEdgeClusterMemberAllocationPoolType AllocationPool { get; set; }
        /// <summary>
        /// To reallocate TIER1 logical router on new or existing edge cluster
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"To reallocate TIER1 logical router on new or existing edge cluster")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EdgeClusterId { get; set; }
    }
}
