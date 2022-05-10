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
    /// BGP neighbor learned/advertised route details.
    /// </summary>
    [NSXTProperty(Description: @"BGP neighbor learned/advertised route details.")]
    public class NSXTBgpNeighborRouteDetailsType 
    {
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// BGP neighbor id
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_id")]
        public string? NeighborId { get; set; }
        /// <summary>
        /// Array of BGP neighbor route details per transport node.
        /// </summary>
        [JsonProperty(PropertyName = "per_transport_node_routes")]
        public IList<NSXTRoutesPerTransportNodeType> PerTransportNodeRoutes { get; set; }
        /// <summary>
        /// BGP neighbor peer IP address.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
