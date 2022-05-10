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
    /// Transport tunnel status.
    /// </summary>
    [NSXTProperty(Description: @"Transport tunnel status.")]
    public class NSXTL2VPNTransportTunnelStatusType 
    {
        /// <summary>
        /// Resource types of L2VPN Transport tunnels
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpntransportTunnelStatusResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_id")]
        public NSXTResourceReferenceType TunnelId { get; set; }
    }
}
