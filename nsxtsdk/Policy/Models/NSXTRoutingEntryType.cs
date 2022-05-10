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
    /// Routing table entry.
    /// </summary>
    [NSXTProperty(Description: @"Routing table entry.")]
    public class NSXTRoutingEntryType 
    {
        /// <summary>
        /// Logical router component(Service Router/Distributed Router) id
        /// </summary>
        [JsonProperty(PropertyName = "lr_component_id")]
        public string? LrComponentId { get; set; }
        /// <summary>
        /// Next hop address.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        public string? NextHop { get; set; }
        /// <summary>
        /// Logical router component(Service Router/Distributed Router) type
        /// </summary>
        [JsonProperty(PropertyName = "lr_component_type")]
        public string? LrComponentType { get; set; }
        /// <summary>
        /// Network CIDR.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// Route type in routing table.
        /// t0c - Tier-0 Connected
        /// t0s - Tier-0 Static
        /// b - BGP
        /// t0n - Tier-0 NAT
        /// t1s - Tier-1 Static
        /// t1c - Tier-1 Connected
        /// t1n: Tier-1 NAT
        /// t1l: Tier-1 LB VIP
        /// t1ls: Tier-1 LB SNAT
        /// t1d: Tier-1 DNS FORWARDER
        /// t1ipsec: Tier-1 IPSec
        /// isr: Inter-SR
        /// </summary>
        [JsonProperty(PropertyName = "route_type")]
        public string? RouteType { get; set; }
        /// <summary>
        /// The policy path of the interface which is used as the next hop
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        public string? Interface { get; set; }
        /// <summary>
        /// Admin distance.
        /// </summary>
        [JsonProperty(PropertyName = "admin_distance")]
        public int? AdminDistance { get; set; }
    }
}
