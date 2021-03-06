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
    /// L2Vpn transport tunnel peer code.
    /// </summary>
    [NSXTProperty(Description: @"L2Vpn transport tunnel peer code.")]
    public class NSXTL2VpnTransportTunnelPeerCodeType 
    {
        /// <summary>
        /// Copy this code to paste on the remote end of the tunnel.
        /// This is a base64 encoded string which has all the configuration for tunnel.
        /// E.g local/remote ips and protocol, encryption algorithm, etc. Peer code also
        /// contains PSK; be careful when sharing or storing it.
        /// </summary>
        [JsonProperty(PropertyName = "peer_code", Required = Required.AllowNull)]
        public string PeerCode { get; set; }
        /// <summary>
        /// Policy path referencing the transport tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnel_path", Required = Required.AllowNull)]
        public string TransportTunnelPath { get; set; }
    }
}
