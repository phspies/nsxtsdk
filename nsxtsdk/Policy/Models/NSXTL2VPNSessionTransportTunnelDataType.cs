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
    /// L2VPN Session Transport Tunnel Data uses a peer code which has all the
        /// information to create the transport tunnel.
    /// </summary>
    [NSXTProperty(Description: @"L2VPN Session Transport Tunnel Data uses a peer code which has all theinformation to create the transport tunnel.")]
    public class NSXTL2VPNSessionTransportTunnelDataType 
    {
        /// <summary>
        /// IPv4 Address of local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "local_address", Required = Required.AllowNull)]
        public string LocalAddress { get; set; }
        /// <summary>
        /// Peer code represents a base64 encoded string which has
        /// all the configuration for tunnel. E.g local/peer ips and
        /// protocol, encryption algorithm, etc. Peer code also contains
        /// PSK; be careful when sharing or storing it.
        /// </summary>
        [JsonProperty(PropertyName = "peer_code")]
        public string? PeerCode { get; set; }
        /// <summary>
        /// IPv4 Address of Peer endpoint on remote site.
        /// </summary>
        [JsonProperty(PropertyName = "peer_address", Required = Required.AllowNull)]
        public string PeerAddress { get; set; }
    }
}
