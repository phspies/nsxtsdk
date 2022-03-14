// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTL2VpnsessionStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Transport tunnels status.
        /// </summary>
        public IList<NSXTL2VPNTransportTunnelStatusType> TransportTunnels { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2VPN session identifier.
        /// </summary>
        public string? SessionId { get; set; }
    }
}
