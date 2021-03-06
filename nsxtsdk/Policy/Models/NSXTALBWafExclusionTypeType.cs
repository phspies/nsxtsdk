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
    /// Advanced load balancer WafExclusionType object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafExclusionType object")]
    public class NSXTALBWafExclusionTypeType 
    {
        /// <summary>
        /// Case sensitivity to use for the matching.
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafExclusionTypeMatchCaseEnumType? MatchCase { get; set; }
        /// <summary>
        /// String Operation to use for matching the Exclusion.
        /// Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,
        /// DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as EQUALS.
        /// </summary>
        [JsonProperty(PropertyName = "match_op")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafExclusionTypeMatchOpEnumType? MatchOp { get; set; }
    }
}
