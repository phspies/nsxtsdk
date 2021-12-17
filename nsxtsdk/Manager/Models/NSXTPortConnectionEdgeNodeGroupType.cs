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
    public class NSXTPortConnectionEdgeNodeGroupType : NSXTPortConnectionEntityType
    {
        public NSXTPortConnectionEdgeNodeGroupType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_nodes")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTTransportNodeType> EdgeNodes { get; set; }
        /// <summary>
        /// Id of the logical router
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id of the logical router")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LogicalRouterId { get; set; }
    }
}
