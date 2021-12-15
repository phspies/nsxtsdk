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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLocaleServicesType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy paths to edge nodes. For Tier1 gateway, the field is used to
        /// statically assign the ordered list of up to two edge nodes for
        /// stateful services. To enable auto allocation of nodes from the
        /// specified edge cluster the field must be left unset. The auto
        /// allocation of nodes is supported only for the Tier1 gateway.  For
        /// Tier0 gateway specified edge is used as a preferred edge node
        /// when failover mode is set to PREEMPTIVE, not applicable otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_edge_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Policy paths to edge nodes. For Tier1 gateway, the field is used tostatically assign the ordered list of up to two edge nodes forstateful services. To enable auto allocation of nodes from thespecified edge cluster the field must be left unset. The autoallocation of nodes is supported only for the Tier1 gateway.  ForTier0 gateway specified edge is used as a preferred edge nodewhen failover mode is set to PREEMPTIVE, not applicable otherwise.")]
        public IList<string> PreferredEdgePaths { get; set; }
        /// <summary>
        /// This configuration can be defined only for Active-Standby Tier0 gateway to provide redundancy. For mulitple external
        /// interfaces, multiple HA VIP configs must be defined and each config will pair exactly two external interfaces. The VIP
        /// will move and will always be owned by the Active node. When this property is configured, configuration of
        /// dynamic-routing is not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ha_vip_configs")]
        [NSXTProperty(IsRequired: false, Description: @"This configuration can be defined only for Active-Standby Tier0 gateway to provide redundancy. For mulitple external interfaces, multiple HA VIP configs must be defined and each config will pair exactly two external interfaces. The VIP will move and will always be owned by the Active node. When this property is configured, configuration of dynamic-routing is not allowed.")]
        public IList<NSXTTier0HaVipConfigType> HaVipConfigs { get; set; }
        /// <summary>
        /// Configure all route redistribution properties like enable/disable redistributon, redistribution rule and so on.
        /// </summary>
        [JsonProperty(PropertyName = "route_redistribution_config")]
        [NSXTProperty(IsRequired: false, Description: @"Configure all route redistribution properties like enable/disable redistributon, redistribution rule and so on.")]
        public NSXTTier0RouteRedistributionConfigType RouteRedistributionConfig { get; set; }
        /// <summary>
        /// Policy path to edge cluster. Auto-assigned on Tier0 if associated
        /// enforcement-point has only one edge cluster.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path to edge cluster. Auto-assigned on Tier0 if associatedenforcement-point has only one edge cluster.")]
        public string? EdgeClusterPath { get; set; }
        /// <summary>
        /// This profile is applied to all static route peers in this locale. BFD
        /// profile configured on static route peers takes precedence over global
        /// configuration. If this field is empty, a default profile is applied to
        /// all peers.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"This profile is applied to all static route peers in this locale. BFDprofile configured on static route peers takes precedence over globalconfiguration. If this field is empty, a default profile is applied toall peers.")]
        public string? BfdProfilePath { get; set; }
        /// <summary>
        /// Enable redistribution of different types of routes on Tier-0.
        /// This property is only valid for locale-service under Tier-0.
        /// This property is deprecated, please use "route_redistribution_config"
        /// property to configure redistribution rules.
        /// </summary>
        [JsonProperty(PropertyName = "route_redistribution_types")]
        [NSXTProperty(IsRequired: false, Description: @"Enable redistribution of different types of routes on Tier-0.This property is only valid for locale-service under Tier-0.This property is deprecated, please use &quot;route_redistribution_config&quot;property to configure redistribution rules.")]
        public IList<string> RouteRedistributionTypes { get; set; }
    }
}