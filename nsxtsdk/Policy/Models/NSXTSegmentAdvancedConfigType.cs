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
    public class NSXTSegmentAdvancedConfigType : NSXTConnectivityAdvancedConfigType
    {
        public NSXTSegmentAdvancedConfigType()
        {
            UrpfMode = test
        }
        /// <summary>
        /// An ordered list of routing policies to forward traffic to the next hop.
        /// </summary>
        [JsonProperty(PropertyName = "local_egress_routing_policies")]
        [NSXTProperty(IsRequired: false, Description: @"An ordered list of routing policies to forward traffic to the next hop.")]
        public IList<NSXTLocalEgressRoutingEntryType> LocalEgressRoutingPolicies { get; set; }
        /// <summary>
        /// ID populated by NSX when NSX on DVPG is used to indicate the source DVPG. Currently, only DVPortgroups are identified as
        /// Discovered Segments. The origin_id is the identifier of DVPortgroup from the source vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID populated by NSX when NSX on DVPG is used to indicate the source DVPG. Currently, only DVPortgroups are identified as Discovered Segments. The origin_id is the identifier of DVPortgroup from the source vCenter server.")]
        public string? OriginId { get; set; }
        /// <summary>
        /// The name of the switching uplink teaming policy for the Segment. This name corresponds to one of the switching uplink
        /// teaming policy names listed in TransportZone associated with the Segment. See transport_zone_path property above for
        /// more details. When this property is not specified, the segment will not have a teaming policy associated with it and the
        /// host switch's default teaming policy will be used by MP.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_name")]
        [NSXTProperty(IsRequired: false, Description: @"The name of the switching uplink teaming policy for the Segment. This name corresponds to one of the switching uplink teaming policy names listed in TransportZone associated with the Segment. See transport_zone_path property above for more details. When this property is not specified, the segment will not have a teaming policy associated with it and the host switch&apos;s default teaming policy will be used by MP.")]
        public string? UplinkTeamingPolicyName { get; set; }
        /// <summary>
        /// This profile is applie dto the downlink logical router port created
        /// while attaching this semgnet to tier-0 or tier-1. If this field is
        /// empty, NDRA profile of the router is applied to the newly created
        /// port.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"This profile is applie dto the downlink logical router port createdwhile attaching this semgnet to tier-0 or tier-1. If this field isempty, NDRA profile of the router is applied to the newly createdport.")]
        public string? NdraProfilePath { get; set; }
        /// <summary>
        /// When set to true, all the ports created on this segment will behave
        /// in a hybrid fashion. The hybrid port indicates to NSX that the
        /// VM intends to operate in underlay mode, but retains the ability to
        /// forward egress traffic to the NSX overlay network.
        /// This property is only applicable for segment created with transport
        /// zone type OVERLAY_STANDARD.
        /// This property cannot be modified after segment is created.
        /// </summary>
        [JsonProperty(PropertyName = "hybrid")]
        [NSXTProperty(IsRequired: false, Description: @"When set to true, all the ports created on this segment will behavein a hybrid fashion. The hybrid port indicates to NSX that theVM intends to operate in underlay mode, but retains the ability toforward egress traffic to the NSX overlay network.This property is only applicable for segment created with transportzone type OVERLAY_STANDARD.This property cannot be modified after segment is created.")]
        public bool? Hybrid { get; set; }
        /// <summary>
        /// This property is used to enable proximity routing with local egress.
        /// When set to true, logical router interface (downlink) connecting
        /// Segment to Tier0/Tier1 gateway is configured with prefix-length 32.
        /// </summary>
        [JsonProperty(PropertyName = "local_egress")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to enable proximity routing with local egress.When set to true, logical router interface (downlink) connectingSegment to Tier0/Tier1 gateway is configured with prefix-length 32.")]
        public bool? LocalEgress { get; set; }
        /// <summary>
        /// Enable multicast on the downlink LRP created to connect the segment to
        /// Tier0/Tier1 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "multicast")]
        [NSXTProperty(IsRequired: false, Description: @"Enable multicast on the downlink LRP created to connect the segment toTier0/Tier1 gateway.")]
        public bool? Multicast { get; set; }
        /// <summary>
        /// A behaviour required for Firewall As A Service (FaaS) where the segment BUM traffic
        /// is confined within the edge node that this segment belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "node_local_switch")]
        [NSXTProperty(IsRequired: false, Description: @"A behaviour required for Firewall As A Service (FaaS) where the segment BUM trafficis confined within the edge node that this segment belongs to.")]
        public bool? NodeLocalSwitch { get; set; }
        /// <summary>
        /// Policy path to IP address pools.
        /// </summary>
        [JsonProperty(PropertyName = "address_pool_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path to IP address pools.")]
        public IList<string> AddressPoolPaths { get; set; }
        /// <summary>
        /// When set to true, any port attached to this logical switch will
        /// not be visible through VC/ESX UI
        /// </summary>
        [JsonProperty(PropertyName = "inter_router")]
        [NSXTProperty(IsRequired: false, Description: @"When set to true, any port attached to this logical switch willnot be visible through VC/ESX UI")]
        public bool? InterRouter { get; set; }
        /// <summary>
        /// This URPF mode is applied to the downlink logical router port created
        /// while attaching this segment to tier-0 or tier-1.
        /// </summary>
        [JsonProperty(PropertyName = "urpf_mode")]
        [NSXTProperty(IsRequired: false, Description: @"This URPF mode is applied to the downlink logical router port createdwhile attaching this segment to tier-0 or tier-1.")]
        public NSXTSegmentAdvancedConfigUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// The type of source from where the DVPortgroup is discovered
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        [NSXTProperty(IsRequired: false, Description: @"The type of source from where the DVPortgroup is discovered")]
        public NSXTSegmentAdvancedConfigOriginTypeEnumType? OriginType { get; set; }
    }
}
