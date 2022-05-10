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
    /// To filter the routes advertised by the TIER1 LR to TIER0 LR. Filtering will be based on the type of route and the prefix
        /// operator configured.
    /// </summary>
    [NSXTProperty(Description: @"To filter the routes advertised by the TIER1 LR to TIER0 LR. Filtering will be based on the type of route and the prefix operator configured.")]
    public class NSXTAdvertisementRuleFilterType 
    {
        /// <summary>
        /// GE prefix operator filters all the routes having network subset of any of the networks configured in Advertise rule. EQ
        /// prefix operator filter all the routes having network equal to any of the network configured in Advertise rule.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAdvertisementRuleFilterPrefixOperatorEnumType PrefixOperator { get; set; }
        /// <summary>
        /// Array of route types to filter routes
        /// </summary>
        [JsonProperty(PropertyName = "match_route_types", Required = Required.AllowNull)]
        public IList<string> MatchRouteTypes { get; set; }
    }
}
