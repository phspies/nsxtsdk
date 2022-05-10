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
    public class NSXTEdgeMemberAllocationStatusType 
    {
        /// <summary>
        /// List of services allocated on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "allocated_services")]
        public IList<NSXTAllocatedServiceType> AllocatedServices { get; set; }
        /// <summary>
        /// Display name of edge cluster member. Defaults to ID if not set.
        /// </summary>
        [JsonProperty(PropertyName = "node_display_name")]
        public string? NodeDisplayName { get; set; }
        /// <summary>
        /// System generated index for transport node backed by edge node.
        /// </summary>
        [JsonProperty(PropertyName = "member_index")]
        public int? MemberIndex { get; set; }
        /// <summary>
        /// Allocation details of pools defined on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_pools")]
        public IList<NSXTAllocationPoolType> AllocationPools { get; set; }
        /// <summary>
        /// System allotted UUID of edge node.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
    }
}
