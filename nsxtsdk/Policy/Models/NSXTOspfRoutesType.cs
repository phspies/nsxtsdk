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
    /// OSPF Routes Per Edge.
    /// </summary>
    [NSXTProperty(Description: @"OSPF Routes Per Edge.")]
    public class NSXTOspfRoutesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "route_details")]
        public IList<NSXTOspfRouteType> RouteDetails { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
        /// <summary>
        /// Display name to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_display_name")]
        public string? EdgeDisplayName { get; set; }
    }
}
