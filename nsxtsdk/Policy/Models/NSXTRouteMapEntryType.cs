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
    /// Route map entry
    /// </summary>
    [NSXTProperty(Description: @"Route map entry")]
    public class NSXTRouteMapEntryType 
    {
        /// <summary>
        /// Action for the route map entry
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRouteMapEntryActionEnumType Action { get; set; }
        /// <summary>
        /// Community list match criteria for route map.
        /// Properties community_list_matches and prefix_list_matches are mutually
        /// exclusive and cannot be used in the same route map entry.
        /// </summary>
        [JsonProperty(PropertyName = "community_list_matches")]
        public IList<NSXTCommunityMatchCriteriaType> CommunityListMatches { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "set")]
        public NSXTRouteMapEntrySetType Set { get; set; }
        /// <summary>
        /// Prefix list match criteria for route map.
        /// Properties community_list_matches and prefix_list_matches are mutually
        /// exclusive and cannot be used in the same route map entry.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_list_matches")]
        public IList<string> PrefixListMatches { get; set; }
    }
}
