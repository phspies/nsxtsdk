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
    public class NSXTLogicalRouterIPTunnelPortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Tunnel port subnets.
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Admin state of port.
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterIptunnelPortAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Associated VPN session identifier.
        /// </summary>
        [JsonProperty(PropertyName = "vpn_session_id")]
        public string? VpnSessionId { get; set; }
    }
}
