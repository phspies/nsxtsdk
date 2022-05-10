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
    /// Set criteria for route map entry
    /// </summary>
    [NSXTProperty(Description: @"Set criteria for route map entry")]
    public class NSXTRouteMapEntrySetType 
    {
        /// <summary>
        /// For incoming and import route_maps on receiving both v6 global
        /// and v6 link-local address for the route, prefer to use the global
        /// address as the next hop. By default, it prefers the link-local next hop.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_global_v6_next_hop")]
        public bool? PreferGlobalV6NextHop { get; set; }
        /// <summary>
        /// Multi exit descriminator (MED) is a hint to BGP neighbors about
        /// the preferred path into an autonomous system (AS) that has multiple
        /// entry points. A lower MED value is preferred over a higher value.
        /// </summary>
        [JsonProperty(PropertyName = "med")]
        public int? Med { get; set; }
        /// <summary>
        /// Local preference indicates the degree of preference for one BGP route
        /// over other BGP routes. The path with highest local preference is
        /// preferred.
        /// </summary>
        [JsonProperty(PropertyName = "local_preference")]
        public long? LocalPreference { get; set; }
        /// <summary>
        /// Weight is used to select a route when multiple routes are available
        /// to the same network. Route with the highest weight is preferred.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
        /// <summary>
        /// AS path prepend to influence route selection.
        /// </summary>
        [JsonProperty(PropertyName = "as_path_prepend")]
        public string? AsPathPrepend { get; set; }
        /// <summary>
        /// Set BGP regular or large community for matching routes. A maximum of one value for each community
        /// type separated by space. Well-known community name, community value in aa:nn (2byte:2byte) format for regular
        /// community and community value in aa:bb:nn (4byte:4byte:4byte) format for large community are supported.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public string? Community { get; set; }
    }
}
