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
    public class NSXTL2VpnSessionType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of transport tunnels for redundancy.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> TransportTunnels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_encapsulation")]
        public NSXTL2VpnTunnelEncapsulationType TunnelEncapsulation { get; set; }
        /// <summary>
        /// Enable to extend all the associated logical switches.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_tcp_mss_clamping")]
        public NSXTL2VpnTcpMssClampingType L2vpnTcpMssClamping { get; set; }
        /// <summary>
        /// L2VPN service id
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_service_id", Required = Required.AllowNull)]
        public string L2vpnServiceId { get; set; }
    }
}
