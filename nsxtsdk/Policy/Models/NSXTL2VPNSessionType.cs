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
    public class NSXTL2VPNSessionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// TCP Maximum Segment Size Clamping Direction and Value. This feature is supported for L2VPN Sessions that are
        /// Server mode only.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_mss_clamping")]
        [NSXTProperty(IsRequired: false, Description: @"TCP Maximum Segment Size Clamping Direction and Value. This feature is supported for L2VPN Sessions that areServer mode only.")]
        public NSXTL2TcpMaxSegmentSizeClampingType TcpMssClamping { get; set; }
        /// <summary>
        /// List of transport tunnels for redundancy.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of transport tunnels for redundancy.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> TransportTunnels { get; set; }
        /// <summary>
        /// Tunnel encapsulation config. This property only applies in CLIENT
        /// mode. It is auto-populated from the L2VPNSessionData.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_encapsulation")]
        [NSXTProperty(IsRequired: false, Description: @"Tunnel encapsulation config. This property only applies in CLIENTmode. It is auto-populated from the L2VPNSessionData.")]
        public NSXTL2VPNTunnelEncapsulationType TunnelEncapsulation { get; set; }
        /// <summary>
        /// Enable to extend all the associated segments.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable to extend all the associated segments.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
    }
}