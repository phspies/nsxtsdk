using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Node usage for load balancer contains basic information and LB entity
        /// usages and capacity for the given node. Only edge node is supported.
    /// </summary>
    [NSXTProperty(Description: @"Node usage for load balancer contains basic information and LB entityusages and capacity for the given node. Only edge node is supported.")]
    public class NSXTLBNodeUsageType 
    {
        /// <summary>
        /// The property identifies the load balancer node usage type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
        /// <summary>
        /// The property identifies the node path for load balancer node usage.
        /// For example, node_path=/infra/sites/default/enforcement-points/default
        /// /edge-clusters/85175e0b-4d74-461d-83e1-f3b785adef9c/edge-nodes
        /// /86e077c0-449f-11e9-87c8-02004eb37029.
        /// </summary>
        [JsonProperty(PropertyName = "node_path", Required = Required.AllowNull)]
        public string NodePath { get; set; }
    }
}
