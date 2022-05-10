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
    /// L2VPN tunnel encapsulation config
    /// </summary>
    [NSXTProperty(Description: @"L2VPN tunnel encapsulation config")]
    public class NSXTL2VpnTunnelEncapsulationType 
    {
        /// <summary>
        /// IP Address of the tunnel port. For hub, the IP is allocated from L2VpnService logical_tap_ip_pool. All sessions on same
        /// L2VpnService get the same local_endpoint_ip. For spoke, the IP must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "local_endpoint_ip")]
        public string? LocalEndpointIp { get; set; }
        /// <summary>
        /// Encapsulation protocol used by the tunnel
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnTunnelEncapsulationProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// IP Address of the peer tunnel port. For hub, the IP is allocated from L2VpnService logical_tap_ip_pool. For spoke, the
        /// IP must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "peer_endpoint_ip")]
        public string? PeerEndpointIp { get; set; }
    }
}
