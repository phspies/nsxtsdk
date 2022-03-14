// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSegmentAdvancedConfigType : NSXTConnectivityAdvancedConfigType
    {
        /// <summary>
        /// An ordered list of routing policies to forward traffic to the next hop.
        /// </summary>
        public IList<NSXTLocalEgressRoutingEntryType> LocalEgressRoutingPolicies { get; set; }
        /// <summary>
        /// ID populated by NSX when NSX on DVPG is used to indicate the source DVPG. Currently, only DVPortgroups are identified as
        /// Discovered Segments. The origin_id is the identifier of DVPortgroup from the source vCenter server.
        /// </summary>
        public string? OriginId { get; set; }
        /// <summary>
        /// The name of the switching uplink teaming policy for the Segment. This name corresponds to one of the switching uplink
        /// teaming policy names listed in TransportZone associated with the Segment. See transport_zone_path property above for
        /// more details. When this property is not specified, the segment will not have a teaming policy associated with it and the
        /// host switch's default teaming policy will be used by MP.
        /// </summary>
        public string? UplinkTeamingPolicyName { get; set; }
        /// <summary>
        /// This profile is applie dto the downlink logical router port created
        /// while attaching this semgnet to tier-0 or tier-1. If this field is
        /// empty, NDRA profile of the router is applied to the newly created
        /// port.
        /// </summary>
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
        public bool? Hybrid { get; set; }
        /// <summary>
        /// This property is used to enable proximity routing with local egress.
        /// When set to true, logical router interface (downlink) connecting
        /// Segment to Tier0/Tier1 gateway is configured with prefix-length 32.
        /// </summary>
        public bool? LocalEgress { get; set; }
        /// <summary>
        /// Enable multicast on the downlink LRP created to connect the segment to
        /// Tier0/Tier1 gateway.
        /// </summary>
        public bool? Multicast { get; set; }
        /// <summary>
        /// A behaviour required for Firewall As A Service (FaaS) where the segment BUM traffic
        /// is confined within the edge node that this segment belongs to.
        /// </summary>
        public bool? NodeLocalSwitch { get; set; }
        /// <summary>
        /// Policy path to IP address pools.
        /// </summary>
        public IList<string> AddressPoolPaths { get; set; }
        /// <summary>
        /// When set to true, any port attached to this logical switch will
        /// not be visible through VC/ESX UI
        /// </summary>
        public bool? InterRouter { get; set; }
        /// <summary>
        /// This URPF mode is applied to the downlink logical router port created
        /// while attaching this segment to tier-0 or tier-1.
        /// </summary>
        public NSXTSegmentAdvancedConfigUrpfModeEnumType? UrpfMode { get; set; }
        /// <summary>
        /// The type of source from where the DVPortgroup is discovered
        /// </summary>
        public NSXTSegmentAdvancedConfigOriginTypeEnumType? OriginType { get; set; }
    }
}
