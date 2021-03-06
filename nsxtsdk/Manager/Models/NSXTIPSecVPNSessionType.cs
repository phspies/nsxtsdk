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
    public class NSXTIPSecVPNSessionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Peer endpoint identifier.
        /// </summary>
        [JsonProperty(PropertyName = "peer_endpoint_id", Required = Required.AllowNull)]
        public string PeerEndpointId { get; set; }
        /// <summary>
        /// Identifier of VPN Service linked with local endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_service_id")]
        public string? IpsecVpnServiceId { get; set; }
        /// <summary>
        /// Local endpoint identifier.
        /// </summary>
        [JsonProperty(PropertyName = "local_endpoint_id", Required = Required.AllowNull)]
        public string LocalEndpointId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_mss_clamping")]
        public NSXTTcpMssClampingType TcpMssClamping { get; set; }
        /// <summary>
        /// Enable/Disable IPSec VPN session.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
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
        public NSXTIpsecVpnsessionResourceTypeEnumType ResourceType { get; set; }
    }
}
