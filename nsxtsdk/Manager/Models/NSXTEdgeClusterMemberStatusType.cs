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
    public class NSXTEdgeClusterMemberStatusType 
    {
        /// <summary>
        /// Transport node backed by an Edge node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Transport node backed by an Edge node.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// Status of an edge node
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of an edge node")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTEdgeClusterMemberStatusStatusEnumType Status { get; set; }
    }
}