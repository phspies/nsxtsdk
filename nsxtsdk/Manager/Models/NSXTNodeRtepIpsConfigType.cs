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
    public class NSXTNodeRtepIpsConfigType 
    {
        /// <summary>
        /// System generated index for cluster member
        /// </summary>
        [JsonProperty(PropertyName = "member_index")]
        public int? MemberIndex { get; set; }
        /// <summary>
        /// Remote tunnel endpoint ip address.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_ips")]
        public IList<string> RtepIps { get; set; }
        /// <summary>
        /// Identifier of the transport node backed by an Edge node
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
