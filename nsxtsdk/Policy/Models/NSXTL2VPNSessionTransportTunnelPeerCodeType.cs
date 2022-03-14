// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// L2VPN transport tunnel peer code.
    /// </summary>
    [NSXTProperty(Description: @"L2VPN transport tunnel peer code.")]
    public class NSXTL2VPNSessionTransportTunnelPeerCodeType 
    {
        /// <summary>
        /// Peer code represents a base64 encoded string which has
        /// all the configuration for tunnel. E.g local/peer ips and
        /// protocol, encryption algorithm, etc. Peer code also contains
        /// PSK; be careful when sharing or storing it.
        /// </summary>
        public string? PeerCode { get; set; }
        /// <summary>
        /// Policy Path referencing the transport tunnel.
        /// </summary>
        public string? TransportTunnelPath { get; set; }
    }
}
