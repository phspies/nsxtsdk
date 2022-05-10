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
    public class NSXTEdgeClusterMemberAllocationProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "allocation_pool")]
        public NSXTEdgeClusterMemberAllocationPoolType AllocationPool { get; set; }
        /// <summary>
        /// Flag to enable the auto-relocation of standby service router running
        /// on edge cluster and node associated with the logical router. Only
        /// dynamically allocated tier1 logical routers are considered for the
        /// relocation.
        /// </summary>
        [JsonProperty(PropertyName = "enable_standby_relocation")]
        public bool? EnableStandbyRelocation { get; set; }
        /// <summary>
        /// Allocation type is used to specify the mode used to allocate the LR.
        /// This is populated only for TIER1 logical router and for TIER0 this
        /// will be null.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterMemberAllocationProfileAllocationTypeEnumType? AllocationType { get; set; }
    }
}
