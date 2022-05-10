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
    /// Segment specific L2 VPN configuration
    /// </summary>
    [NSXTProperty(Description: @"Segment specific L2 VPN configuration")]
    public class NSXTL2ExtensionType 
    {
        /// <summary>
        /// Policy paths corresponding to the associated L2 VPN sessions
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_paths")]
        public IList<string> L2vpnPaths { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "local_egress")]
        public NSXTLocalEgressType LocalEgress { get; set; }
        /// <summary>
        /// This property has been deprecated. Please use the property l2vpn_paths
        /// for setting the paths of associated L2 VPN session. This property will
        /// continue to work as expected to provide backwards compatibility.
        /// However, when both l2vpn_path and l2vpn_paths properties
        /// are specified, only l2vpn_paths is used.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_path")]
        public string? L2vpnPath { get; set; }
        /// <summary>
        /// Tunnel ID
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_id")]
        public int? TunnelId { get; set; }
    }
}
