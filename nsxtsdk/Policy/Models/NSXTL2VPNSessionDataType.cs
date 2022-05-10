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
        public bool? Enabled { get; set; }
        /// <summary>
        /// List of L2VPN transport tunnel data.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels")]
        public IList<NSXTL2VPNSessionTransportTunnelDataType> TransportTunnels { get; set; }
        /// <summary>
        /// Defaults to id if not set.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Description of L2VPN Session
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
