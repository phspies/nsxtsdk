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
    public class NSXTEdgeClusterMemberStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node", Required = Required.AllowNull)]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// Status of an edge node
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterMemberStatusStatusEnumType Status { get; set; }
    }
}
