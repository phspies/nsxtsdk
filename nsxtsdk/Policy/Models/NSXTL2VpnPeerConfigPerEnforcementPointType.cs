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
    /// Peer config per Enforcement Point to configure the other side of the tunnel.
    /// </summary>
    [NSXTProperty(Description: @"Peer config per Enforcement Point to configure the other side of the tunnel.")]
    public class NSXTL2VpnPeerConfigPerEnforcementPointType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnPeerConfigPerEnforcementPointResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point to which the config belongs.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
