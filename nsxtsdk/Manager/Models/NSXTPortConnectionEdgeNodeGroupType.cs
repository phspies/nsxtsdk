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
    public class NSXTPortConnectionEdgeNodeGroupType : NSXTPortConnectionEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_nodes")]
        public IList<NSXTTransportNodeType> EdgeNodes { get; set; }
        /// <summary>
        /// Id of the logical router
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        public string LogicalRouterId { get; set; }
    }
}
