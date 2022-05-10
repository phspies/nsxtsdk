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
    public class NSXTLogicalRouterType : NSXTManagedResourceType
    {
        /// <summary>
        /// For stateful services, the logical router should be associated with
        /// edge cluster. For TIER 1 logical router, for manual placement of
        /// service router within the cluster, edge cluster member indices needs
        /// to be provided else same will be auto-allocated. You can provide
        /// maximum two indices for HA ACTIVE_STANDBY. For TIER0 logical router
        /// this property is no use and placement is derived from logical router
        /// uplink or loopback port.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_indices")]
        public long? EdgeClusterMemberIndices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_profiles")]
        public NSXTIPv6ProfilesType Ipv6Profiles { get; set; }
        /// <summary>
        /// List of Firewall sections related to Logical Router.
        /// </summary>
        [JsonProperty(PropertyName = "firewall_sections")]
        public IList<NSXTResourceReferenceType> FirewallSections { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "allocation_profile")]
        public NSXTEdgeClusterMemberAllocationProfileType AllocationProfile { get; set; }
        /// <summary>
        /// Determines the behavior when a logical router instance restarts after
        /// a failure. If set to PREEMPTIVE, the preferred node will take over,
        /// even if it causes another failure. If set to NON_PREEMPTIVE, then the
        /// instance that restarted will remain secondary.
        /// This property must not be populated unless the high_availability_mode property
        /// is set to ACTIVE_STANDBY.
        /// If high_availability_mode property is set to ACTIVE_STANDBY and this property
        /// is not specified then default will be NON_PREEMPTIVE.
        /// </summary>
        [JsonProperty(PropertyName = "failover_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterFailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "advanced_config")]
        public NSXTLogicalRouterConfigType AdvancedConfig { get; set; }
        /// <summary>
        /// TIER0 for external connectivity.
        /// TIER1 for two tier topology with TIER0 on top.
        /// VRF for isolation of routing table on TIER0.
        /// </summary>
        [JsonProperty(PropertyName = "router_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterRouterTypeEnumType RouterType { get; set; }
        /// <summary>
        /// Preferred edge cluster member index which is required
        /// for PREEMPTIVE failover mode. Used for Tier0 routers only.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_edge_cluster_member_index")]
        public long? PreferredEdgeClusterMemberIndex { get; set; }
        /// <summary>
        /// High availability mode
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterHighAvailabilityModeEnumType? HighAvailabilityMode { get; set; }
        /// <summary>
        /// Used for tier0 routers
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id")]
        public string? EdgeClusterId { get; set; }
    }
}
