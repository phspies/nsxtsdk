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
    /// L2VPN session status.
    /// </summary>
    [NSXTProperty(Description: @"L2VPN session status.")]
    public class NSXTL2VPNSessionStatusType 
    {
        /// <summary>
        /// L2 VPN session status, specifies UP/DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnsessionStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Transport tunnels status.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels")]
        public IList<NSXTL2VPNTransportTunnelStatusType> TransportTunnels { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2VPN session identifier.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public string? SessionId { get; set; }
    }
}
