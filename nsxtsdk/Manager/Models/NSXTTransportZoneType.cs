using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportZoneType : NSXTManagedResourceType
    {
        /// <summary>
        /// Only one transport zone can be the default one for a given transport zone type. APIs that need transport zone can choose
        /// to use the default transport zone if a transport zone is not given.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// The transport type of this transport zone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportZoneTransportTypeEnumType TransportType { get; set; }
        /// <summary>
        /// This field is populated only if the transport zone was created by NSX system to support security on vSphere Distributed
        /// Switch (vDS). The origin_id will refer to the identifier of corresponding vDS from it's parent vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
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
        /// The names of switching uplink teaming policies that all transport nodes in this transport zone must support. An
        /// exception will be thrown if a transport node within the transport zone does not support a named teaming policy. The user
        /// will need to first ensure all trasnport nodes support the desired named teaming policy before assigning it to the
        /// transport zone. If the field is not specified, the host switch's default teaming policy will be used.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_names")]
        public IList<string> UplinkTeamingPolicyNames { get; set; }
        /// <summary>
        /// Identifiers of the transport zone profiles associated with this TransportZone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_profile_ids")]
        public IList<NSXTTransportZoneProfileTypeIdEntryType> TransportZoneProfileIds { get; set; }
    }
}
