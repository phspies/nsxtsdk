// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"L2 VPN session status, specifies UP/DOWN.")]
        public NSXTL2VpnsessionStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Transport tunnels status.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels")]
        [NSXTProperty(IsRequired: false, Description: @"Transport tunnels status.")]
        public IList<NSXTL2VPNTransportTunnelStatusType> TransportTunnels { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"L2VPN display name.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2VPN session identifier.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        [NSXTProperty(IsRequired: false, Description: @"L2VPN session identifier.")]
        public string? SessionId { get; set; }
    }
}
