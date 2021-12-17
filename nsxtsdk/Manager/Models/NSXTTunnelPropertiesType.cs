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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTunnelPropertiesType : NSXTResourceType
    {
        public NSXTTunnelPropertiesType()
        {
        }
        /// <summary>
        /// Status of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of tunnel")]
        public NSXTTunnelPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// Corresponds to the interface where local_ip_address is routed.
        /// </summary>
        [JsonProperty(PropertyName = "egress_interface")]
        [NSXTProperty(IsRequired: false, Description: @"Corresponds to the interface where local_ip_address is routed.")]
        public string? EgressInterface { get; set; }
        /// <summary>
        /// UUID of the remote transport node
        /// </summary>
        [JsonProperty(PropertyName = "remote_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"UUID of the remote transport node")]
        public string? RemoteNodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTBFDPropertiesType Bfd { get; set; }
        /// <summary>
        /// Local IP address of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "local_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Local IP address of tunnel")]
        public string? LocalIp { get; set; }
        /// <summary>
        /// Time at which the Tunnel status has been fetched last time.
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_time")]
        [NSXTProperty(IsRequired: false, Description: @"Time at which the Tunnel status has been fetched last time.")]
        public long? LastUpdatedTime { get; set; }
        /// <summary>
        /// Name of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of tunnel")]
        public string? Name { get; set; }
        /// <summary>
        /// Represents the display name of the remote transport node at the other end of the tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "remote_node_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the display name of the remote transport node at the other end of the tunnel.")]
        public string? RemoteNodeDisplayName { get; set; }
        /// <summary>
        /// Tunnel encap
        /// </summary>
        [JsonProperty(PropertyName = "encap")]
        [NSXTProperty(IsRequired: false, Description: @"Tunnel encap")]
        public NSXTTunnelPropertiesEncapEnumType? Encap { get; set; }
        /// <summary>
        /// Latency type.
        /// </summary>
        [JsonProperty(PropertyName = "latency_type")]
        [NSXTProperty(IsRequired: false, Description: @"Latency type.")]
        public NSXTTunnelPropertiesLatencyTypeEnumType? LatencyType { get; set; }
        /// <summary>
        /// The latency value is set only when latency_type is VALID.
        /// </summary>
        [JsonProperty(PropertyName = "latency_value")]
        [NSXTProperty(IsRequired: false, Description: @"The latency value is set only when latency_type is VALID.")]
        public long? LatencyValue { get; set; }
        /// <summary>
        /// Remote IP address of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Remote IP address of tunnel")]
        public string? RemoteIp { get; set; }
    }
}
