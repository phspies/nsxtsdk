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
    public class NSXTSegmentType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Subnet configuration. Max 1 subnet
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTSegmentSubnetType> Subnets { get; set; }
        /// <summary>
        /// Policy path to the connecting Tier-0 or Tier-1.
        /// Valid only for segments created under Infra.
        /// This field can only be used for overlay segments.
        /// VLAN backed segments cannot have connectivity path set.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_path")]
        public string? ConnectivityPath { get; set; }
        /// <summary>
        /// This property could be used for vendor specific configuration in key value
        /// string pairs, the setting in extra_configs will be automatically inheritted
        /// by segment ports in the Segment.
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        public IList<NSXTSegmentExtraConfigType> ExtraConfigs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "advanced_config")]
        public NSXTSegmentAdvancedConfigType AdvancedConfig { get; set; }
        /// <summary>
        /// Static address binding used for the Segment. This field is deprecated and will be removed in a future release. Please
        /// use address_bindings in SegmentPort to configure static bindings.
        /// </summary>
        [JsonProperty(PropertyName = "address_bindings")]
        public IList<NSXTPortAddressBindingEntryType> AddressBindings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "federation_config")]
        public NSXTFederationConnectivityConfigType FederationConfig { get; set; }
        /// <summary>
        /// Policy path to the EvpnTenantConfig resource. Supported only for Route-Server Evpn Mode.
        /// Supported only for Overlay Segments. This will be populated for both Parent and Child segments
        /// participating in Evpn Route-Server Mode.
        /// </summary>
        [JsonProperty(PropertyName = "evpn_tenant_config_path")]
        public string? EvpnTenantConfigPath { get; set; }
        /// <summary>
        /// Mac pool id that associated with a Segment.
        /// </summary>
        [JsonProperty(PropertyName = "mac_pool_id")]
        public string? MacPoolId { get; set; }
        /// <summary>
        /// Multiple distinct L2 bridge profiles can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "bridge_profiles")]
        public IList<NSXTBridgeProfileConfigType> BridgeProfiles { get; set; }
        /// <summary>
        /// VLAN ids for a VLAN backed Segment.
        /// Can be a VLAN id or a range of VLAN ids specified with '-' in between.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ids")]
        public IList<string> VlanIds { get; set; }
        /// <summary>
        /// DNS domain name
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public string? DomainName { get; set; }
        /// <summary>
        /// Used for overlay connectivity of segments. The overlay_id
        /// should be allocated from the pool as definied by enforcement-point.
        /// If not provided, it is auto-allocated from the default pool on the
        /// enforcement-point.
        /// </summary>
        [JsonProperty(PropertyName = "overlay_id")]
        public int? OverlayId { get; set; }
        /// <summary>
        /// Policy path to DHCP server or relay configuration to use for all
        /// IPv4 & IPv6 subnets configured on this segment.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_config_path")]
        public string? DhcpConfigPath { get; set; }
        /// <summary>
        /// This property is deprecated. The property will continue to work as
        /// expected for existing segments. The segments that are newly created
        /// with ls_id will be ignored.
        /// Sepcify pre-creted logical switch id for Segment.
        /// </summary>
        [JsonProperty(PropertyName = "ls_id")]
        public string? LsId { get; set; }
        /// <summary>
        /// Flag to indicate if the Segment is a Child-Segment of type EVPN.
        /// </summary>
        [JsonProperty(PropertyName = "evpn_segment")]
        public bool? EvpnSegment { get; set; }
        /// <summary>
        /// Admin state represents desired state of segment. It does not reflect the state of other logical entities
        /// connected/attached to the segment.
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Policy path to metadata proxy configuration. Multiple distinct MD proxies can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "metadata_proxy_paths")]
        public IList<string> MetadataProxyPaths { get; set; }
        /// <summary>
        /// Segment type based on configuration.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentTypeEnumType? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "l2_extension")]
        public NSXTL2ExtensionType L2Extension { get; set; }
        /// <summary>
        /// Policy path to the transport zone. Supported for VLAN backed segments
        /// as well as Overlay Segments.
        /// - This field is required for VLAN backed Segments.
        /// - For overlay Segments, it is auto assigned if only one transport zone
        /// exists in the enforcement point. Default transport zone is auto
        /// assigned for  overlay segments if none specified.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_path")]
        public string? TransportZonePath { get; set; }
        /// <summary>
        /// If this field is not set for overlay segment, then the default of MTEP
        /// will be used.
        /// </summary>
        [JsonProperty(PropertyName = "replication_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentReplicationModeEnumType? ReplicationMode { get; set; }
    }
}
