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
    public class NSXTGlobalConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Global configuration of maximum number of ARP entries per transport
        /// node at each Tier0/Tier1 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "arp_limit_per_gateway")]
        [NSXTProperty(IsRequired: false, Description: @"Global configuration of maximum number of ARP entries per transportnode at each Tier0/Tier1 gateway.")]
        //[System.ComponentModel.DataAnnotations.MinLength(5000)]
        //[System.ComponentModel.DataAnnotations.MaxLength(50000)]
        public long? ArpLimitPerGateway { get; set; }
        /// <summary>
        /// This value defines the upper threshold for the Maximum Transmission Unit (MTU) value that can be configured at a
        /// physical uplink level or a logical routing uplink level in a NSX domain. All Uplink profiles validate against this value
        /// so that the MTU specified in an Uplink profile does not exceed this global upper threshold. Similarly, when this value
        /// is modified, the new value must be greater than or equal to any existing Uplink profile's MTU.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_mtu_threshold")]
        [NSXTProperty(IsRequired: false, Description: @"This value defines the upper threshold for the Maximum Transmission Unit (MTU) value that can be configured at a physical uplink level or a logical routing uplink level in a NSX domain. All Uplink profiles validate against this value so that the MTU specified in an Uplink profile does not exceed this global upper threshold. Similarly, when this value is modified, the new value must be greater than or equal to any existing Uplink profile&apos;s MTU.")]
        [NSXTDefaultProperty(Default: "")]
        public long? UplinkMtuThreshold { get; set; }
        /// <summary>
        /// Contains the FIPSGlobalConfig object.
        /// </summary>
        [JsonProperty(PropertyName = "fips")]
        [NSXTProperty(IsRequired: false, Description: @"Contains the FIPSGlobalConfig object.")]
        public NSXTFIPSGlobalConfigType Fips { get; set; }
        /// <summary>
        /// Configure forwarding mode for routing. This setting does not
        /// restrict configuration for other modes.
        /// </summary>
        [JsonProperty(PropertyName = "l3_forwarding_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Configure forwarding mode for routing. This setting does notrestrict configuration for other modes.")]
        [NSXTDefaultProperty(Default: "IPV4_ONLY")]
        public NSXTGlobalConfigL3ForwardingModeEnumType? L3ForwardingMode { get; set; }
        /// <summary>
        /// This is the global default MAC address for all VDRs in all transport nodes in a NSX system. It can be changed only when
        /// there is no transport node in the NSX system. This value cannot be same as vdr_mac_nested. When the property
        /// "allow_changing_vdr_mac_in_use" is false, it can not be changed if the current VDR MAC is being used by any transport
        /// node. A transport node uses this VDR MAC if any host switch in the node is in OVERLAY transport zone(s) but none of the
        /// transport zone(s) has "nested_nsx" property being true.
        /// </summary>
        [JsonProperty(PropertyName = "vdr_mac")]
        [NSXTProperty(IsRequired: false, Description: @"This is the global default MAC address for all VDRs in all transport nodes in a NSX system. It can be changed only when there is no transport node in the NSX system. This value cannot be same as vdr_mac_nested. When the property &quot;allow_changing_vdr_mac_in_use&quot; is false, it can not be changed if the current VDR MAC is being used by any transport node. A transport node uses this VDR MAC if any host switch in the node is in OVERLAY transport zone(s) but none of the transport zone(s) has &quot;nested_nsx&quot; property being true.")]
        [NSXTDefaultProperty(Default: "02:50:56:56:44:52")]
        public string? VdrMac { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"This is the global default MAC address for all VDRs in all transport nodes in a NSX system nested in another NSX system. It can be changed only when there is no transport node in the NSX system. All transport zones in such a nested NSX system will have the &quot;nested_nsx&quot; property being true so that all transport nodes will use this MAC for the VDR ports to avoid conflict with the VDR MAC in the outer NSX system. When the property &quot;allow_changing_vdr_mac_in_use&quot; is false, it can not be changed if the current VDR MAC is being used by any transport node in a nested NSX environment. A transport node uses this VDR MAC if any host switch in the node is in an OVERLAY transport zone whose &quot;nested_nsx&quot; property is true.")]
        [NSXTDefaultProperty(Default: "02:50:56:56:44:53")]
        public string? VdrMacNested { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"When this flag is set to true, it is allowed to change the VDR MAC being used by existing transport nodes in a NSX system. The VDR MAC used by a host switch in a transport node is decided by the OVERLAY transport zone(s) which the host switch joins. If any of the OVERLAY transport zone(s) has &quot;nested_nsx&quot; property set to true, the MAC in &quot;vdr_mac_nested&quot; is used; otherwise the MAC in &quot;vdr_mac&quot; is used. Thus the VDR MAC being used by a host switch in a transport node can be changed in below ways. If the host switch is not in any OVERLAY transport zone whose &quot;nested_nsx&quot; property is true but is in an OVERLAY transport zone, the first way is updating the &quot;vdr_mac&quot; property. The 2nd way is updating one of the OVERLAY tranport zones joined by the host switch to set &quot;nested_nsx&quot; property true which will make the host switch use the VDR MAC in &quot;vdr_mac_nested&quot;. The third way is directly updating the transport node to add an OVERLAY transport zone whose &quot;nested_nsx&quot; property is true into the host switch which will also make the host switch use the VDR MAC in &quot;vdr_mac_nested&quot;. If the host switch is in some OVERLAY transport zone(s) whose &quot;nested_nsx&quot; property is true, the first way is updating the &quot;vdr_mac_nested&quot; property. The 2nd way is updating all those OVERLAY tranport zones to set &quot;nested_nsx&quot; property false which will make the host switch use the VDR MAC in &quot;vdr_mac&quot;. The third way is directly updating the transport node to remove all those OVERLAY transport zones from the host switch which will also make the host switch use the VDR MAC in &quot;vdr_mac&quot;. Please note that changing the VDR MAC being used by existing transport nodes will most likely cause traffic disruption and network outage!")]
        public bool? AllowChangingVdrMacInUse { get; set; }
        /// <summary>
        /// The operation collector is defined to receive stats from hosts.
        /// The VRNI and WAVE_FRONT collector type can be defined to collect the metric data.
        /// The WAVE_FRONT collector type can only be used in VMC mode.
        /// </summary>
        [JsonProperty(PropertyName = "operation_collectors")]
        [NSXTProperty(IsRequired: false, Description: @"The operation collector is defined to receive stats from hosts.The VRNI and WAVE_FRONT collector type can be defined to collect the metric data.The WAVE_FRONT collector type can only be used in VMC mode.")]
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
        [NSXTProperty(IsRequired: false, Description: @"Maximum transmission unit (MTU) specifies the size of the largestpacket that a network protocol can transmit.This is the global default MTU for all the EXTERNAL (uplink) andSERVICE (CSP) interfaces in the NSX domain. There is no option tooverride this value at the transport zone level or transport nodelevel.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1280)]
        public long? Mtu { get; set; }
    }
}