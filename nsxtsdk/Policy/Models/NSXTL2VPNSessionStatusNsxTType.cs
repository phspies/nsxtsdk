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
    [NSXTProperty(Description: @"")]
    public class NSXTL2VPNSessionStatusNsxTType : NSXTL2VPNSessionStatusPerEPType
    {
        /// <summary>
        /// Transport tunnels status.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels")]
        public IList<NSXTL2VPNSessionTransportTunnelStatusType> TransportTunnels { get; set; }
        /// <summary>
        /// Display name of l2vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2 VPN session status, specifies UP/DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnsessionStatusNsxTRuntimeStatusEnumType? RuntimeStatus { get; set; }
    }
}
