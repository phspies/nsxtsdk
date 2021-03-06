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
    public class NSXTGlobalConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Global configuration of maximum number of ARP entries per transport
        /// node at each Tier0/Tier1 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "arp_limit_per_gateway")]
        public int? ArpLimitPerGateway { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "external_gateway_bfd")]
        public NSXTExternalGatewayBfdConfigType ExternalGatewayBfd { get; set; }
        /// <summary>
        /// This is the global default MAC address for all VDRs in all transport nodes in a NSX system nested in another NSX system.
        /// It can be changed only when there is no transport node in the NSX system. All transport zones in such a nested NSX
        /// system will have the "nested_nsx" property being true so that all transport nodes will use this MAC for the VDR ports to
        /// avoid conflict with the VDR MAC in the outer NSX system. When the property "allow_changing_vdr_mac_in_use" is false, it
        /// can not be changed if the current VDR MAC is being used by any transport node in a nested NSX environment. A transport
        /// node uses this VDR MAC if any host switch in the node is in an OVERLAY transport zone whose "nested_nsx" property is
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "vdr_mac_nested")]
        public string? VdrMacNested { get; set; }
        /// <summary>
        /// This is the global default MTU for all the physical uplinks in a NSX domain. This is the default value for the optional
        /// uplink profile MTU field. When the MTU value is not specified in the uplink profile, this global value will be used.
        /// This value can be overridden by providing a value for the optional MTU field in the uplink profile. Whenever this value
        /// is updated, the updated value will only be propagated to the uplinks that don't have the MTU value in their uplink
        /// profiles. If this value is not set, the default value of 1700 will be used. The Transport Node state can be monitored to
        /// confirm if the updated MTU value has been realized.
        /// </summary>
        [JsonProperty(PropertyName = "physical_uplink_mtu")]
        public int? PhysicalUplinkMtu { get; set; }
        /// <summary>
        /// This property is a part of OpsGlobalConfig object. Use /infra/ops-global-config instead.
        /// The VRNI and WAVE_FRONT collector type can be defined to collect the metric data.
        /// The WAVE_FRONT collector type can only be used in VMC mode.
        /// </summary>
        [JsonProperty(PropertyName = "operation_collectors")]
        public IList<NSXTGlobalCollectorConfigType> OperationCollectors { get; set; }
        /// <summary>
        /// Maximum transmission unit (MTU) specifies the size of the largest
        /// packet that a network protocol can transmit.
        /// This is the global default MTU for all the EXTERNAL (uplink) and
        /// SERVICE (CSP) interfaces in the NSX domain. There is no option to
        /// override this value at the transport zone level or transport node
        /// level.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
        /// <summary>
        /// Flag to enable/disable ECMP load balancing.
        /// By default ECMP load balancing is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "lb_ecmp")]
        public bool? LbEcmp { get; set; }
        /// <summary>
        /// This value defines the upper threshold for the Maximum Transmission Unit (MTU) value that can be configured at a
        /// physical uplink level or a logical routing uplink level in a NSX domain. All Uplink profiles validate against this value
        /// so that the MTU specified in an Uplink profile does not exceed this global upper threshold. Similarly, when this value
        /// is modified, the new value must be greater than or equal to any existing Uplink profile's MTU.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_mtu_threshold")]
        public int? UplinkMtuThreshold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "fips")]
        public NSXTFIPSGlobalConfigType Fips { get; set; }
        /// <summary>
        /// Configure forwarding mode for routing. This setting does not
        /// restrict configuration for other modes.
        /// </summary>
        [JsonProperty(PropertyName = "l3_forwarding_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGlobalConfigL3ForwardingModeEnumType? L3ForwardingMode { get; set; }
        /// <summary>
        /// This is the global default MAC address for all VDRs in all transport nodes in a NSX system. It can be changed only when
        /// there is no transport node in the NSX system. This value cannot be same as vdr_mac_nested. When the property
        /// "allow_changing_vdr_mac_in_use" is false, it can not be changed if the current VDR MAC is being used by any transport
        /// node. A transport node uses this VDR MAC if any host switch in the node is in OVERLAY transport zone(s) but none of the
        /// transport zone(s) has "nested_nsx" property being true.
        /// </summary>
        [JsonProperty(PropertyName = "vdr_mac")]
        public string? VdrMac { get; set; }
        /// <summary>
        /// When this flag is set to true, it is allowed to change the VDR MAC being used by existing transport nodes in a NSX
        /// system. The VDR MAC used by a host switch in a transport node is decided by the OVERLAY transport zone(s) which the host
        /// switch joins. If any of the OVERLAY transport zone(s) has "nested_nsx" property set to true, the MAC in "vdr_mac_nested"
        /// is used; otherwise the MAC in "vdr_mac" is used. Thus the VDR MAC being used by a host switch in a transport node can be
        /// changed in below ways. If the host switch is not in any OVERLAY transport zone whose "nested_nsx" property is true but
        /// is in an OVERLAY transport zone, the first way is updating the "vdr_mac" property. The 2nd way is updating one of the
        /// OVERLAY tranport zones joined by the host switch to set "nested_nsx" property true which will make the host switch use
        /// the VDR MAC in "vdr_mac_nested". The third way is directly updating the transport node to add an OVERLAY transport zone
        /// whose "nested_nsx" property is true into the host switch which will also make the host switch use the VDR MAC in
        /// "vdr_mac_nested". If the host switch is in some OVERLAY transport zone(s) whose "nested_nsx" property is true, the first
        /// way is updating the "vdr_mac_nested" property. The 2nd way is updating all those OVERLAY tranport zones to set
        /// "nested_nsx" property false which will make the host switch use the VDR MAC in "vdr_mac". The third way is directly
        /// updating the transport node to remove all those OVERLAY transport zones from the host switch which will also make the
        /// host switch use the VDR MAC in "vdr_mac". Please note that changing the VDR MAC being used by existing transport nodes
        /// will most likely cause traffic disruption and network outage!
        /// </summary>
        [JsonProperty(PropertyName = "allow_changing_vdr_mac_in_use")]
        public bool? AllowChangingVdrMacInUse { get; set; }
        /// <summary>
        /// This is the global default MTU for all the physical remote tunnel endpoints in an NSX domain. Please consider intersite
        /// link MTU minus any external overhead when defining the MTU. If this value is not set, the default value of 1500 will be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "remote_tunnel_physical_mtu")]
        public int? RemoteTunnelPhysicalMtu { get; set; }
        /// <summary>
        /// When this flag is set true, certain types of BUM packets will be sent to all VTEPs in the global VTEP table, ignoring
        /// the logical switching span.
        /// </summary>
        [JsonProperty(PropertyName = "global_replication_mode_enabled")]
        public bool? GlobalReplicationModeEnabled { get; set; }
    }
}
