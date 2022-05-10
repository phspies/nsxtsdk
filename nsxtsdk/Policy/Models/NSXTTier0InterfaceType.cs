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
    public class NSXTTier0InterfaceType : NSXTBaseTier0InterfaceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ospf")]
        public NSXTPolicyInterfaceOspfConfigType Ospf { get; set; }
        /// <summary>
        /// Specify association of interface with edge cluster member.
        /// This property is deprecated, use edge_path instead. When both
        /// properties are specifed, only edge_path property is used.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_index")]
        public int? EdgeClusterMemberIndex { get; set; }
        /// <summary>
        /// Unicast Reverse Path Forwarding mode
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0InterfaceUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// Array of prefix lists used to specify filtering for ARP proxy.
        /// Prefixes in this array are used to configure ARP proxy entries on Tier-0
        /// gateway (for uplinks).
        /// </summary>
        [JsonProperty(PropertyName = "proxy_arp_filters")]
        public IList<string> ProxyArpFilters { get; set; }
        /// <summary>
        /// Policy path to edge node to handle external connectivity.
        /// Required when interface type is EXTERNAL.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path")]
        public string? EdgePath { get; set; }
        /// <summary>
        /// Specify Segment to which this interface is connected to.
        /// Either segment_path or ls_id property is required.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        public string? SegmentPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "multicast")]
        public NSXTTier0InterfacePimConfigType Multicast { get; set; }
        /// <summary>
        /// This flag is used to enable/disable admin state on tier-0 service port.
        /// If admin_state flag value is not specified then default is UP. When set to UP then
        /// traffic on service port will be enabled and service port is enabled from routing
        /// perspective. When set to DOWN then traffic on service port will be disabled and
        /// service port is down from routing perspective. This flag is experimental because
        /// it will be used in V2T BYOT migration. This flag should not be set to UP or DOWN if
        /// EVPN is configured, and tier-0 LR is in A/S mode. Also this flag can not be set to
        /// UP or DOWN for service interfaces which are configured on vrf-lite.
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0InterfaceAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Configuration IPv6 NDRA profile. Only one
        /// NDRA profile can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_profile_paths")]
        public IList<string> Ipv6ProfilePaths { get; set; }
        /// <summary>
        /// IGMP local join groups configuration.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_local_join_groups")]
        public IList<string> IgmpLocalJoinGroups { get; set; }
        /// <summary>
        /// Specify logical switch to which tier-0 interface is connected for
        /// external access.
        /// This property is deprecated, use segment_path instead. Both
        /// properties cannot be used together.
        /// </summary>
        [JsonProperty(PropertyName = "ls_id")]
        public string? LsId { get; set; }
        /// <summary>
        /// Maximum transmission unit (MTU) specifies the size of the largest
        /// packet that a network protocol can transmit.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
        /// <summary>
        /// Interface type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0InterfaceTypeEnumType? Type { get; set; }
        /// <summary>
        /// Vlan id.
        /// </summary>
        [JsonProperty(PropertyName = "access_vlan_id")]
        public long? AccessVlanId { get; set; }
    }
}
