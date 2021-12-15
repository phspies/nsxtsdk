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
    /// L2VPN Session Data represents meta data necessary to create
        /// the L2VPN Session. It is represented by an array of peer code
        /// for each tunnel.
    /// </summary>
    [NSXTProperty(Description: @"L2VPN Session Data represents meta data necessary to createthe L2VPN Session. It is represented by an array of peer codefor each tunnel.")]
    public class NSXTL2VPNSessionDataType 
    {
        /// <summary>
        /// Enable to extend all the associated segments.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable to extend all the associated segments.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// List of L2VPN transport tunnel data.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels")]
        [NSXTProperty(IsRequired: false, Description: @"List of L2VPN transport tunnel data.")]
        public IList<NSXTL2VPNSessionTransportTunnelDataType> TransportTunnels { get; set; }
        /// <summary>
        /// Defaults to id if not set.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Defaults to id if not set.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Description of L2VPN Session
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"Description of L2VPN Session")]
        public string? Description { get; set; }
    }
}