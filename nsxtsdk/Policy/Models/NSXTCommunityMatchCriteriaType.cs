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
    /// Match criteria based on a community list
    /// </summary>
    [NSXTProperty(Description: @"Match criteria based on a community list")]
    public class NSXTCommunityMatchCriteriaType 
    {
        /// <summary>
        /// Match operator for community list entries. Not valid when a regular expression is specified for criteria.
        /// </summary>
        [JsonProperty(PropertyName = "match_operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunityMatchCriteriaMatchOperatorEnumType? MatchOperator { get; set; }
        /// <summary>
        /// Match criteria specified as a community list path or a regular
        /// expression.
        /// </summary>
        [JsonProperty(PropertyName = "criteria", Required = Required.AllowNull)]
        public string Criteria { get; set; }
    }
}
