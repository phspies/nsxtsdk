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
    /// Node usage for load balancer contains basic information and LB entity
        /// usages and capacity for the given node.
    /// </summary>
    [NSXTProperty(Description: @"Node usage for load balancer contains basic information and LB entityusages and capacity for the given node.")]
    public class NSXTLbNodeUsageType 
    {
        /// <summary>
        /// The property identifies the node UUID for load balancer node usage.
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The property identifies the node UUID for load balancer node usage.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeId { get; set; }
        /// <summary>
        /// The property identifies the load balancer node usage type.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The property identifies the load balancer node usage type.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLbNodeUsageTypeEnumType Type { get; set; }
    }
}