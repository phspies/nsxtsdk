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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTunnelPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Status of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTunnelPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// Corresponds to the interface where local_ip_address is routed.
        /// </summary>
        [JsonProperty(PropertyName = "egress_interface")]
        public string? EgressInterface { get; set; }
        /// <summary>
        /// UUID of the remote transport node
        /// </summary>
        [JsonProperty(PropertyName = "remote_node_id")]
        public string? RemoteNodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd")]
        public NSXTBFDPropertiesType Bfd { get; set; }
        /// <summary>
        /// Local IP address of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "local_ip")]
        public string? LocalIp { get; set; }
        /// <summary>
        /// Time at which the Tunnel status has been fetched last time.
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_time")]
        public long? LastUpdatedTime { get; set; }
        /// <summary>
        /// Name of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Represents the display name of the remote transport node at the other end of the tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "remote_node_display_name")]
        public string? RemoteNodeDisplayName { get; set; }
        /// <summary>
        /// Tunnel encap
        /// </summary>
        [JsonProperty(PropertyName = "encap")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTunnelPropertiesEncapEnumType? Encap { get; set; }
        /// <summary>
        /// Latency type.
        /// </summary>
        [JsonProperty(PropertyName = "latency_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTunnelPropertiesLatencyTypeEnumType? LatencyType { get; set; }
        /// <summary>
        /// The latency value is set only when latency_type is VALID.
        /// </summary>
        [JsonProperty(PropertyName = "latency_value")]
        public long? LatencyValue { get; set; }
        /// <summary>
        /// Remote IP address of tunnel
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip")]
        public string? RemoteIp { get; set; }
    }
}
