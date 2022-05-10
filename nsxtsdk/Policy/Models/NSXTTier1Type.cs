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
    public class NSXTTier1Type : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "federation_config")]
        public NSXTFederationGatewayConfigType FederationConfig { get; set; }
        /// <summary>
        /// Indicates if logging should be enabled for the default whitelisting rule. This field is
        /// deprecated and recommended to change Rule logging field. Note that this
        /// field is not synchronized with default logging field.
        /// </summary>
        [JsonProperty(PropertyName = "default_rule_logging")]
        public bool? DefaultRuleLogging { get; set; }
        /// <summary>
        /// Supports edge node allocation at different sizes for routing and
        /// load balancer service to meet performance and scalability requirements.
        /// ROUTING: Allocate edge node to provide routing services.
        /// LB_SMALL, LB_MEDIUM, LB_LARGE, LB_XLARGE: Specify size of load balancer
        /// service that will be configured on TIER1 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "pool_allocation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier1PoolAllocationEnumType? PoolAllocation { get; set; }
        /// <summary>
        /// Specify Tier-1 connectivity to Tier-0 instance.
        /// </summary>
        [JsonProperty(PropertyName = "tier0_path")]
        public string? Tier0Path { get; set; }
        /// <summary>
        /// Specify high-availability mode for Tier-1.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier1HaModeEnumType? HaMode { get; set; }
        /// <summary>
        /// Flag to enable standby service router relocation.
        /// Standby relocation is not enabled until edge cluster is configured
        /// for Tier1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_standby_relocation")]
        public bool? EnableStandbyRelocation { get; set; }
        /// <summary>
        /// Determines the behavior when a Tier-1 instance restarts after a
        /// failure. If set to PREEMPTIVE, the preferred node will take over,
        /// even if it causes another failure. If set to NON_PREEMPTIVE,
        /// then the instance that restarted will remain secondary.
        /// Only applicable when edge cluster is configured in Tier1
        /// locale-service.
        /// </summary>
        [JsonProperty(PropertyName = "failover_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier1FailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// Maximum number of ARP entries per transport node.
        /// </summary>
        [JsonProperty(PropertyName = "arp_limit")]
        public int? ArpLimit { get; set; }
        /// <summary>
        /// This field is deprecated and recommended to change Rule action field.
        /// Note that this field is not synchornied with default rule field.
        /// </summary>
        [JsonProperty(PropertyName = "force_whitelisting")]
        public bool? ForceWhitelisting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "intersite_config")]
        public NSXTIntersiteGatewayConfigType IntersiteConfig { get; set; }
        /// <summary>
        /// DHCP configuration for Segments connected to Tier-1. DHCP service is
        /// enabled in relay mode.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_config_paths")]
        public IList<string> DhcpConfigPaths { get; set; }
        /// <summary>
        /// Configuration IPv6 NDRA and DAD profiles. Either or both
        /// NDRA and/or DAD profiles can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_profile_paths")]
        public IList<string> Ipv6ProfilePaths { get; set; }
        /// <summary>
        /// Route advertisement rules and filtering
        /// </summary>
        [JsonProperty(PropertyName = "route_advertisement_rules")]
        public IList<NSXTRouteAdvertisementRuleType> RouteAdvertisementRules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "qos_profile")]
        public NSXTGatewayQosProfileConfigType QosProfile { get; set; }
        /// <summary>
        /// Disable or enable gateway fiewall.
        /// </summary>
        [JsonProperty(PropertyName = "disable_firewall")]
        public bool? DisableFirewall { get; set; }
        /// <summary>
        /// Tier1 connectivity type for reference. Property value is not validated
        /// with Tier1 configuration.
        /// ROUTED: Tier1 is connected to Tier0 gateway and routing is enabled.
        /// ISOLATED: Tier1 is not connected to any Tier0 gateway.
        /// NATTED: Tier1 is in ROUTED type with NAT configured locally.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier1TypeEnumType? Type { get; set; }
        /// <summary>
        /// Enable different types of route advertisements.
        /// When not specified, routes to IPSec VPN local-endpoint subnets
        /// (TIER1_IPSEC_LOCAL_ENDPOINT) are automatically advertised.
        /// </summary>
        [JsonProperty(PropertyName = "route_advertisement_types")]
        public IList<string> RouteAdvertisementTypes { get; set; }
    }
}
