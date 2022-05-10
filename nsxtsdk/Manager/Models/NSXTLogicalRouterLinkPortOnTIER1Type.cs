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
    public class NSXTLogicalRouterLinkPortOnTIER1Type : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_router_port_id")]
        public NSXTResourceReferenceType LinkedLogicalRouterPortId { get; set; }
        /// <summary>
        /// Please use logical router API to pass edge cluster members indexes manually.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_index")]
        public long? EdgeClusterMemberIndex { get; set; }
    }
}
