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
    /// OSPF route next hop result.
    /// </summary>
    [NSXTProperty(Description: @"OSPF route next hop result.")]
    public class NSXTOspfRouteNextHopResultType 
    {
        /// <summary>
        /// Check whether OSPF route is directly connected.
        /// </summary>
        [JsonProperty(PropertyName = "directly_attached")]
        public bool? DirectlyAttached { get; set; }
        /// <summary>
        /// OSPF policy interface name.
        /// </summary>
        [JsonProperty(PropertyName = "interface_name")]
        public string? InterfaceName { get; set; }
        /// <summary>
        /// next-hop address.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
