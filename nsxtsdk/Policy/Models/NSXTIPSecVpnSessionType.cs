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
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("PolicyBasedIPSecVpnSession", typeof(NSXTPolicyBasedIPSecVpnSessionType))]
    [JsonInheritanceAttribute("RouteBasedIPSecVpnSession", typeof(NSXTRouteBasedIPSecVpnSessionType))]
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVpnSessionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IPSec Pre-shared key. Maximum length of this field is 128 characters.
        /// </summary>
        [JsonProperty(PropertyName = "psk")]
        public string? Psk { get; set; }
        /// <summary>
        /// Policy path referencing Dead Peer Detection (DPD) profile. Default is set to system default profile.
        /// </summary>
        [JsonProperty(PropertyName = "dpd_profile_path")]
        public string? DpdProfilePath { get; set; }
        /// <summary>
        /// Policy path referencing IKE profile to be used. Default is set according to system default profile.
        /// </summary>
        [JsonProperty(PropertyName = "ike_profile_path")]
        public string? IkeProfilePath { get; set; }
        /// <summary>
        /// Enable/Disable IPSec VPN session.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Connection initiation mode used by local endpoint to
        /// establish ike connection with peer site.
        /// INITIATOR - In this mode local endpoint initiates
        /// tunnel setup and will also respond to incoming tunnel
        /// setup requests from peer gateway.
        /// RESPOND_ONLY - In this mode, local endpoint shall only
        /// respond to incoming tunnel setup requests. It shall not
        /// initiate the tunnel setup.
        /// ON_DEMAND - In this mode local endpoint will initiate
        /// tunnel creation once first packet matching the policy
        /// rule is received and will also respond to incoming
        /// initiation request.
        /// </summary>
        [JsonProperty(PropertyName = "connection_initiation_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionConnectionInitiationModeEnumType? ConnectionInitiationMode { get; set; }
        /// <summary>
        /// Policy path referencing Local endpoint. This property is mandatory on LM. It is required on GM only in case of
        /// site_overrides property not provided.
        /// </summary>
        [JsonProperty(PropertyName = "local_endpoint_path")]
        public string? LocalEndpointPath { get; set; }
        /// <summary>
        /// A collection of site specific attributes specificed only on GM
        /// </summary>
        [JsonProperty(PropertyName = "site_overrides")]
        public IList<NSXTSiteOverrideType> SiteOverrides { get; set; }
        /// <summary>
        /// Policy path referencing Tunnel profile to be used. Default is set to system default profile.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_profile_path")]
        public string? TunnelProfilePath { get; set; }
        /// <summary>
        /// Compliance suite.
        /// </summary>
        [JsonProperty(PropertyName = "compliance_suite")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionComplianceSuiteEnumType? ComplianceSuite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_mss_clamping")]
        public NSXTTcpMaximumSegmentSizeClampingType TcpMssClamping { get; set; }
        /// <summary>
        /// Peer authentication mode.
        /// PSK - In this mode a secret key shared between local and
        /// peer sites is to be used for authentication. The secret
        /// key can be a string with a maximum length of 128 characters.
        /// CERTIFICATE - In this mode a certificate defined at the
        /// global level is to be used for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "authentication_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionAuthenticationModeEnumType? AuthenticationMode { get; set; }
        /// <summary>
        /// Peer ID to uniquely identify the peer site. The peer ID is the public IP address of the remote device terminating the
        /// VPN tunnel. When NAT is configured for the peer, enter the private IP address of the peer. This property is mandatory on
        /// LM. It is required on GM only in case of site_overrides property not provided.
        /// </summary>
        [JsonProperty(PropertyName = "peer_id")]
        public string? PeerId { get; set; }
        /// <summary>
        /// Public IPV4 address of the remote device terminating the VPN connection. This property is mandatory on LM. It is
        /// required on GM only in case of site_overrides property not provided.
        /// </summary>
        [JsonProperty(PropertyName = "peer_address")]
        public string? PeerAddress { get; set; }
        /// <summary>
        /// A Policy Based VPN requires to define protect rules that match
        /// local and peer subnets. IPSec security associations is
        /// negotiated for each pair of local and peer subnet.
        /// A Route Based VPN is more flexible, more powerful and recommended over
        /// policy based VPN. IP Tunnel port is created and all traffic routed via
        /// tunnel port is protected. Routes can be configured statically
        /// or can be learned through BGP. A route based VPN is must for establishing
        /// redundant VPN session to remote site.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionResourceTypeEnumType ResourceType { get; set; }
    }
}
