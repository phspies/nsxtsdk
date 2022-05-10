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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalRouterStatusPerNodeType 
    {
        /// <summary>
        /// This field is populated for sateful active-active mode.
        /// Runtime state is only synced among nodes in the same sub cluster.
        /// </summary>
        [JsonProperty(PropertyName = "sub_cluster_id")]
        public string? SubClusterId { get; set; }
        /// <summary>
        /// A service router's HA status on an edge node
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalRouterStatusPerNodeHighAvailabilityStatusEnumType HighAvailabilityStatus { get; set; }
        /// <summary>
        /// id of the service router where the router status is retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "service_router_id")]
        public string? ServiceRouterId { get; set; }
        /// <summary>
        /// Only populated by Policy APIs
        /// </summary>
        [JsonProperty(PropertyName = "edge_path")]
        public string? EdgePath { get; set; }
        /// <summary>
        /// id of the transport node where the router status is retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public string TransportNodeId { get; set; }
    }
}
