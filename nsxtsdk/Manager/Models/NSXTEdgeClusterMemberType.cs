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
    public class NSXTEdgeClusterMemberType 
    {
        /// <summary>
        /// System generated index for cluster member
        /// </summary>
        [JsonProperty(PropertyName = "member_index")]
        public int? MemberIndex { get; set; }
        /// <summary>
        /// display name of edge cluster member
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// description of edge cluster member
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Identifier of the transport node backed by an Edge node
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public string TransportNodeId { get; set; }
    }
}
