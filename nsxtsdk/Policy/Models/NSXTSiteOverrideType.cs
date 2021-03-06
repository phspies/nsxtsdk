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
    /// IPSecVPN site specific attributes specified only on GM. This allows user to specify site specific parameters which
        /// overrides the correspondig attributes in the IPSecVpnSession Object.
    /// </summary>
    [NSXTProperty(Description: @"IPSecVPN site specific attributes specified only on GM. This allows user to specify site specific parameters which overrides the correspondig attributes in the IPSecVpnSession Object.")]
    public class NSXTSiteOverrideType 
    {
        /// <summary>
        /// Public IPV4 address of the remote device terminating the VPN connection.
        /// </summary>
        [JsonProperty(PropertyName = "peer_address", Required = Required.AllowNull)]
        public string PeerAddress { get; set; }
        /// <summary>
        /// Policy path referencing LocateService where SiteOverride attributes will be applied
        /// </summary>
        [JsonProperty(PropertyName = "locale_service_path", Required = Required.AllowNull)]
        public string LocaleServicePath { get; set; }
        /// <summary>
        /// Policy path referencing Local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "local_endpoint_path", Required = Required.AllowNull)]
        public string LocalEndpointPath { get; set; }
        /// <summary>
        /// Peer ID to uniquely identify the peer site. The peer ID is the public IP address of the remote device terminating the
        /// VPN tunnel. When NAT is configured for the peer, enter the private IP address of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "peer_id", Required = Required.AllowNull)]
        public string PeerId { get; set; }
        /// <summary>
        /// IP Tunnel interfaces. This property is mandatory for RouteBasedIpSecVpn session.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_interfaces")]
        public IList<NSXTIPSecVpnTunnelInterfaceType> TunnelInterfaces { get; set; }
    }
}
