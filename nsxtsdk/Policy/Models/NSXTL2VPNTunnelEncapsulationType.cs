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
    /// L2VPN tunnel encapsulation config.
    /// </summary>
    [NSXTProperty(Description: @"L2VPN tunnel encapsulation config.")]
    public class NSXTL2VPNTunnelEncapsulationType 
    {
        /// <summary>
        /// IP Address of the local tunnel port. This property only applies in
        /// CLIENT mode.
        /// </summary>
        [JsonProperty(PropertyName = "local_endpoint_address")]
        public string? LocalEndpointAddress { get; set; }
        /// <summary>
        /// Encapsulation protocol used by the tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpntunnelEncapsulationProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// IP Address of the peer tunnel port. This property only applies in
        /// CLIENT mode.
        /// </summary>
        [JsonProperty(PropertyName = "peer_endpoint_address")]
        public string? PeerEndpointAddress { get; set; }
    }
}
