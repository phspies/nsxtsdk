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
    /// Community match operation
    /// </summary>
    [NSXTProperty(Description: @"Community match operation")]
    public class NSXTCommunityMatchOperationType 
    {
        /// <summary>
        /// Match operator for communities from provided community list id.
        /// MATCH_ANY will match any community
        /// MATCH_ALL will match all communities
        /// MATCH_EXACT will do exact match on community
        /// MATCH_NONE [operator not supported] will not match any community
        /// MATCH_REGEX will match normal communities by evaluating regular
        /// expression
        /// MATCH_LARGE_COMMUNITY_REGEX will match large communities by evaluating
        /// regular expression
        /// </summary>
        [JsonProperty(PropertyName = "match_operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunityMatchOperationMatchOperatorEnumType? MatchOperator { get; set; }
        /// <summary>
        /// Regular expression to match BGP communities. If match_operator
        /// is MATCH_REGEX then this value must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "regular_expression")]
        public string? RegularExpression { get; set; }
        /// <summary>
        /// ID of BGP community list. This value is not required when
        /// match_operator is MATCH_REGEX otherwise required.
        /// </summary>
        [JsonProperty(PropertyName = "community_list_id")]
        public string? CommunityListId { get; set; }
    }
}
