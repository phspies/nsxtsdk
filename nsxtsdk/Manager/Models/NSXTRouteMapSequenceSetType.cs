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
    public class NSXTRouteMapSequenceSetType 
    {
        /// <summary>
        /// For incoming and import route_maps on receiving both v6 global
        /// and v6 link-local address for the route, prefer to use the global
        /// address as the next hop. By default, it prefers the link-local next hop.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_global_v6_next_hop")]
        public bool? PreferGlobalV6NextHop { get; set; }
        /// <summary>
        /// Local preference indicates the degree of preference for one BGP route
        /// over other BGP routes. The path/route with highest local preference
        /// value is preferred/selected. If local preference value is not specified
        /// then it will be considered as 100 by default.
        /// </summary>
        [JsonProperty(PropertyName = "local_preference")]
        public long? LocalPreference { get; set; }
        /// <summary>
        /// Weight used to select certain path
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
        /// <summary>
        /// Set large BGP community, community value shoud be in aa:bb:nn format where aa, bb, nn are unsigned integers with range
        /// [1-4294967295].
        /// </summary>
        [JsonProperty(PropertyName = "large_community")]
        public string? LargeCommunity { get; set; }
        /// <summary>
        /// As Path Prepending to influence path selection
        /// </summary>
        [JsonProperty(PropertyName = "as_path_prepend")]
        public string? AsPathPrepend { get; set; }
        /// <summary>
        /// Set normal BGP community either well-known community name or
        /// community value in aa:nn(2byte:2byte) format.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public string? Community { get; set; }
        /// <summary>
        /// Multi Exit Discriminator (MED)
        /// </summary>
        [JsonProperty(PropertyName = "multi_exit_discriminator")]
        public long? MultiExitDiscriminator { get; set; }
    }
}
