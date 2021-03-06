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
    public class NSXTPolicyTransportZoneType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to indicate if the transport zone is the default one. Only one
        /// transport zone can be the default one for a given transport zone type.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Transport Zone Traffic type. OVERLAY_STANDARD and OVERLAY_ENS are deprecated.
        /// STANDARD, ENS and ENS_INTERRUPT are hostSwitch modes and same can be given in HostTransportNode.HostSwitchSpec.
        /// </summary>
        [JsonProperty(PropertyName = "tz_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyTransportZoneTzTypeEnumType? TzType { get; set; }
        /// <summary>
        /// Policy Transport Zone Profile paths
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_profile_paths")]
        public IList<string> TransportZoneProfilePaths { get; set; }
        /// <summary>
        /// This field is populated only if the transport zone was created by NSX system to support security on vSphere Distributed
        /// Switch (vDS). The origin_id will refer to the identifier of corresponding vDS from it's parent vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// UUID of transport zone on NSX-T enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_id")]
        public string? NsxId { get; set; }
        /// <summary>
        /// This flag should be set to true in nested NSX environment. When the "allow_changing_vdr_mac_in_use" property in the
        /// global config object RoutingGlobalConfig is false, this flag can not be changed if this transport zone is OVERLAY and
        /// the change will make any transport node in this transport zone to change the VDR MAC used in any host switch. When this
        /// flag is true and this transport zone is OVERLAY, all host switches in this transport zone will use the VDR MAC in the
        /// "vdr_mac_nested" property in the global config object RoutingGlobalConfig.
        /// </summary>
        [JsonProperty(PropertyName = "nested_nsx")]
        public bool? NestedNsx { get; set; }
        /// <summary>
        /// The names of switching uplink teaming policies that all transport nodes in this transport zone support. Uplinkin teaming
        /// policies are only valid for VLAN backed transport zones.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_names")]
        public IList<string> UplinkTeamingPolicyNames { get; set; }
    }
}
