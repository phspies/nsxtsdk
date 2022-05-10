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
    /// Tunnel information between two given transport nodes
    /// </summary>
    [NSXTProperty(Description: @"Tunnel information between two given transport nodes")]
    public class NSXTPortConnectionTunnelType 
    {
        /// <summary>
        /// Id of the source transport node
        /// </summary>
        [JsonProperty(PropertyName = "src_node_id", Required = Required.AllowNull)]
        public string SrcNodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_properties", Required = Required.AllowNull)]
        public NSXTTunnelPropertiesType TunnelProperties { get; set; }
    }
}
