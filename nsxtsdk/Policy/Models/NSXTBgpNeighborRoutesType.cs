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
    /// BGP neighbor learned/advertised route details.
    /// </summary>
    [NSXTProperty(Description: @"BGP neighbor learned/advertised route details.")]
    public class NSXTBgpNeighborRoutesType 
    {
        /// <summary>
        /// Array of BGP neighbor route details per edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_routes")]
        public IList<NSXTRoutesPerTransportNodeType> EdgeNodeRoutes { get; set; }
        /// <summary>
        /// BGP neighbor policy path
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_path")]
        public string? NeighborPath { get; set; }
        /// <summary>
        /// Array of BGP neighbor route details per edge node.
        /// </summary>
        [JsonProperty(PropertyName = "egde_node_routes")]
        public IList<NSXTRoutesPerTransportNodeType> EgdeNodeRoutes { get; set; }
        /// <summary>
        /// Enforcement point policy path
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
