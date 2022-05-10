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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVPNPeerEndpointType : NSXTManagedResourceType
    {
        /// <summary>
        /// IPSec Pre-shared key. Maximum length of this field is 128 characters.
        /// </summary>
        [JsonProperty(PropertyName = "psk")]
        public string? Psk { get; set; }
        /// <summary>
        /// Peer identifier.
        /// </summary>
        [JsonProperty(PropertyName = "peer_id", Required = Required.AllowNull)]
        public string PeerId { get; set; }
        /// <summary>
        /// Tunnel profile id to be used. By default it will point to system default profile.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_tunnel_profile_id")]
        public string? IpsecTunnelProfileId { get; set; }
        /// <summary>
        /// Authentication mode used for the peer authentication. For PSK (Pre Shared Key) authentication mode, 'psk' property is
        /// mandatory and for the CERTIFICATE authentication mode, 'peer_id' property is mandatory.
        /// </summary>
        [JsonProperty(PropertyName = "authentication_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnpeerEndpointAuthenticationModeEnumType? AuthenticationMode { get; set; }
        /// <summary>
        /// IPV4 address of peer endpoint on remote site.
        /// </summary>
        [JsonProperty(PropertyName = "peer_address", Required = Required.AllowNull)]
        public string PeerAddress { get; set; }
        /// <summary>
        /// Connection initiation mode used by local
        /// endpoint to establish ike connection with peer endpoint.
        /// INITIATOR - In this mode local endpoint initiates tunnel
        /// setup and will also respond to incoming tunnel setup requests
        /// from peer gateway.
        /// RESPOND_ONLY - In this mode, local endpoint shall only
        /// respond to incoming tunnel setup requests. It shall not
        /// initiate the tunnel setup.
        /// ON_DEMAND - In this mode local endpoint will initiate tunnel
        /// creation once first packet matching the policy rule is
        /// received and will also respond to incoming initiation request.
        /// </summary>
        [JsonProperty(PropertyName = "connection_initiation_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnpeerEndpointConnectionInitiationModeEnumType? ConnectionInitiationMode { get; set; }
        /// <summary>
        /// Dead peer detection (DPD) profile id. Default will be set according to system default policy.
        /// </summary>
        [JsonProperty(PropertyName = "dpd_profile_id")]
        public string? DpdProfileId { get; set; }
        /// <summary>
        /// IKE profile id to be used. Default will be set according to system default policy.
        /// </summary>
        [JsonProperty(PropertyName = "ike_profile_id")]
        public string? IkeProfileId { get; set; }
    }
}
