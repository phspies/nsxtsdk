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
    public class NSXTTier0Type : NSXTPolicyConfigResourceType
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
        /// Specify transit subnets that are used to assign addresses to logical links
        /// connecting tier-0 and tier-1s. Both IPv4 and IPv6 addresses are supported.
        /// When not specified, subnet 100.64.0.0/16 is configured by default.
        /// </summary>
        [JsonProperty(PropertyName = "transit_subnets")]
        public IList<string> TransitSubnets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "advanced_config")]
        public NSXTTier0AdvancedConfigType AdvancedConfig { get; set; }
        /// <summary>
        /// Specify high-availability mode for Tier-0. Default is ACTIVE_ACTIVE.
        /// When ha_mode is changed from ACTIVE_ACTIVE to ACTIVE_STANDBY,
        /// inter SR iBGP (in BGP) is disabled.
        /// Changing ha_mode from ACTIVE_STANDBY to ACTIVE_ACTIVE will enable
        /// inter SR iBGP (in BGP) and previously configured preferred edge nodes
        /// (in Tier0 locale-service) are removed.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0HaModeEnumType? HaMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vrf_config")]
        public NSXTTier0VrfConfigType VrfConfig { get; set; }
        /// <summary>
        /// Specify subnets that are used to assign addresses to logical links
        /// connecting service routers and distributed routers. Only IPv4
        /// addresses are supported.
        /// When not specified, subnet 169.254.0.0/24 is assigned by default
        /// in ACTIVE_ACTIVE HA mode or 169.254.0.0/28 in ACTIVE_STANDBY mode.
        /// </summary>
        [JsonProperty(PropertyName = "internal_transit_subnets")]
        public IList<string> InternalTransitSubnets { get; set; }
        /// <summary>
        /// Determines the behavior when a Tier-0 instance in ACTIVE-STANDBY
        /// high-availability mode restarts after a failure. If set to
        /// PREEMPTIVE, the preferred node will take over, even if it causes
        /// another failure. If set to NON_PREEMPTIVE, then the instance that
        /// restarted will remain secondary. This property is not used when
        /// the ha_mode property is set to ACTIVE_ACTIVE.
        /// Only applicable when edge cluster is configured in Tier0
        /// locale-service.
        /// </summary>
        [JsonProperty(PropertyName = "failover_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0FailoverModeEnumType? FailoverMode { get; set; }
        /// <summary>
        /// Maximum number of ARP entries per transport node.
        /// </summary>
        [JsonProperty(PropertyName = "arp_limit")]
        public int? ArpLimit { get; set; }
        /// <summary>
        /// This field is deprecated and recommended to change Rule action field.
        /// Note that this field is not synchronized with default rule field.
        /// </summary>
        [JsonProperty(PropertyName = "force_whitelisting")]
        public bool? ForceWhitelisting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "intersite_config")]
        public NSXTIntersiteGatewayConfigType IntersiteConfig { get; set; }
        /// <summary>
        /// If you are using EVPN service, then route distinguisher administrator address
        /// should be defined if you need auto generation of route distinguisher on your
        /// VRF configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rd_admin_field")]
        public string? RdAdminField { get; set; }
        /// <summary>
        /// IPv6 NDRA and DAD profiles configuration on Tier0. Either or both
        /// NDRA and/or DAD profiles can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_profile_paths")]
        public IList<string> Ipv6ProfilePaths { get; set; }
        /// <summary>
        /// Disable or enable gateway fiewall.
        /// </summary>
        [JsonProperty(PropertyName = "disable_firewall")]
        public bool? DisableFirewall { get; set; }
        /// <summary>
        /// DHCP configuration for Segments connected to Tier-0. DHCP service is
        /// configured in relay mode.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_config_paths")]
        public IList<string> DhcpConfigPaths { get; set; }
    }
}
