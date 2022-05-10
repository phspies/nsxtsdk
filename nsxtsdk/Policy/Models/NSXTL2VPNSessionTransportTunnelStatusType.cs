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
    /// Transport tunnel status.
    /// </summary>
    [NSXTProperty(Description: @"Transport tunnel status.")]
    public class NSXTL2VPNSessionTransportTunnelStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnsessionTransportTunnelStatusResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy path referencing Transport Tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnel_path")]
        public string? TransportTunnelPath { get; set; }
    }
}
