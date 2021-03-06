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
    /// configuration parameters for Bridge Profile
    /// </summary>
    [NSXTProperty(Description: @"configuration parameters for Bridge Profile")]
    public class NSXTBridgeProfileConfigType 
    {
        /// <summary>
        /// The name of the switching uplink teaming policy for the bridge endpoint. This name corresponds to one fot he switching
        /// uplink teaming policy names listed in teh transport zone. When this property is not specified, the teaming policy is
        /// assigned by MP.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_name")]
        public string? UplinkTeamingPolicyName { get; set; }
        /// <summary>
        /// VLAN specification for bridge endpoint. Either VLAN ID or VLAN ranges can be specified. Not both.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ids")]
        public IList<string> VlanIds { get; set; }
        /// <summary>
        /// Same bridge profile can be configured on different segments. Each bridge profile on a segment must unique.
        /// </summary>
        [JsonProperty(PropertyName = "bridge_profile_path", Required = Required.AllowNull)]
        public string BridgeProfilePath { get; set; }
        /// <summary>
        /// VLAN transport zone should belong to the enforcment-point as the transport zone specified in the segment.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_transport_zone_path", Required = Required.AllowNull)]
        public string VlanTransportZonePath { get; set; }
    }
}
