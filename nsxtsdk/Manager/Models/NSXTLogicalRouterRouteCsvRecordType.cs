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
    public class NSXTLogicalRouterRouteCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Logical router component(Service Router/Distributed Router) id
        /// </summary>
        [JsonProperty(PropertyName = "lr_component_id")]
        public string? LrComponentId { get; set; }
        /// <summary>
        /// The IP of the next hop
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        public string? NextHop { get; set; }
        /// <summary>
        /// Logical router component(Service Router/Distributed Router) type
        /// </summary>
        [JsonProperty(PropertyName = "lr_component_type")]
        public string? LrComponentType { get; set; }
        /// <summary>
        /// CIDR network address
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
        /// <summary>
        /// Route type (USER, CONNECTED, NSX_INTERNAL,..)
        /// </summary>
        [JsonProperty(PropertyName = "route_type", Required = Required.AllowNull)]
        public string RouteType { get; set; }
        /// <summary>
        /// The id of the logical router port which is used as the next hop
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_port_id")]
        public string? LogicalRouterPortId { get; set; }
        /// <summary>
        /// The admin distance of the next hop
        /// </summary>
        [JsonProperty(PropertyName = "admin_distance")]
        public long? AdminDistance { get; set; }
    }
}
