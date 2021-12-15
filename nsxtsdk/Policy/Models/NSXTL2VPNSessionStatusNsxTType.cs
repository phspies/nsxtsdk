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
        [NSXTProperty(IsRequired: false, Description: @"Transport tunnels status.")]
        public IList<NSXTL2VPNSessionTransportTunnelStatusType> TransportTunnels { get; set; }
        /// <summary>
        /// Display name of l2vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display name of l2vpn session.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2 VPN session status, specifies UP/DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [NSXTProperty(IsRequired: false, Description: @"L2 VPN session status, specifies UP/DOWN.")]
        public NSXTL2VpnsessionStatusNsxTRuntimeStatusEnumType? RuntimeStatus { get; set; }
    }
}
