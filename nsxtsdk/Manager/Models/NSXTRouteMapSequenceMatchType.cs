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
    /// Match sequence in route map which is used for matching routes.
        /// IP prefix lists and match community expression are mutually
        /// exclusive fields, one of them must be provided.
    /// </summary>
    [NSXTProperty(Description: @"Match sequence in route map which is used for matching routes.IP prefix lists and match community expression are mutuallyexclusive fields, one of them must be provided.")]
    public class NSXTRouteMapSequenceMatchType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match_community_expression")]
        public NSXTCommunityMatchExpressionType MatchCommunityExpression { get; set; }
        /// <summary>
        /// IPPrefixList Identifiers for RouteMap Sequence Match Criteria
        /// </summary>
        [JsonProperty(PropertyName = "ip_prefix_lists")]
        public IList<string> IpPrefixLists { get; set; }
    }
}
