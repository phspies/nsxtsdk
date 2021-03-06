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
    public class NSXTEdgeClusterMemberTransportNodeType 
    {
        /// <summary>
        /// System generated index for cluster member
        /// </summary>
        [JsonProperty(PropertyName = "member_index", Required = Required.AllowNull)]
        public int MemberIndex { get; set; }
        /// <summary>
        /// Identifier of the transport node backed by an Edge node
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public string TransportNodeId { get; set; }
    }
}
