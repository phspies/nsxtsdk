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
    /// L2Vpn tunnel peer code
    /// </summary>
    [NSXTProperty(Description: @"L2Vpn tunnel peer code")]
    public class NSXTL2VpnTunnelPeerCodeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnel", Required = Required.AllowNull)]
        public NSXTResourceReferenceType TransportTunnel { get; set; }
        /// <summary>
        /// Copy this code to paste on the remote end of the tunnel. This is a base64 encoded string which has all the configuration
        /// for tunnel. E.g tap device local/peer ips and protocol, encryption algorithm, etc. The peer code also contains a
        /// pre-shared key; be careful when sharing or storing it.
        /// </summary>
        [JsonProperty(PropertyName = "peer_code", Required = Required.AllowNull)]
        public string PeerCode { get; set; }
    }
}
