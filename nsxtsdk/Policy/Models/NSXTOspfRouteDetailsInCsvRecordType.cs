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
    public class NSXTOspfRouteDetailsInCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Type to cost of the route.
        /// </summary>
        [JsonProperty(PropertyName = "type_to_cost")]
        public long? TypeToCost { get; set; }
        /// <summary>
        /// route next hop result.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop_neighbor_address")]
        public string? NextHopNeighborAddress { get; set; }
        /// <summary>
        /// Learned route prefix.
        /// </summary>
        [JsonProperty(PropertyName = "route_prefix")]
        public string? RoutePrefix { get; set; }
        /// <summary>
        /// Cost of the route.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public long? Cost { get; set; }
        /// <summary>
        /// OSPF area.
        /// </summary>
        [JsonProperty(PropertyName = "area")]
        public string? Area { get; set; }
        /// <summary>
        /// Type of route.
        /// </summary>
        [JsonProperty(PropertyName = "route_type")]
        public string? RouteType { get; set; }
        /// <summary>
        /// Type of router.
        /// </summary>
        [JsonProperty(PropertyName = "router_type")]
        public string? RouterType { get; set; }
        /// <summary>
        /// OSPF policy interface name.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop_interface_name")]
        public string? NextHopInterfaceName { get; set; }
        /// <summary>
        /// Check whether OSPF route is directly connected.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop_directly_attached")]
        public bool? NextHopDirectlyAttached { get; set; }
        /// <summary>
        /// Policy edge path.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path")]
        public string? EdgePath { get; set; }
    }
}
