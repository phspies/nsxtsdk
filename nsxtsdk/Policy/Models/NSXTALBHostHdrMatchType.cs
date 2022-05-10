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
    /// Advanced load balancer HostHdrMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HostHdrMatch object")]
    public class NSXTALBHostHdrMatchType 
    {
        /// <summary>
        /// Case sensitivity to use for the match.
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhostHdrMatchMatchCaseEnumType? MatchCase { get; set; }
        /// <summary>
        /// String value(s) in the host header.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }
        /// <summary>
        /// Criterion to use for the host header value match.
        /// Enum options - HDR_EXISTS, HDR_DOES_NOT_EXIST,
        /// HDR_BEGINS_WITH, HDR_DOES_NOT_BEGIN_WITH, HDR_CONTAINS,
        /// HDR_DOES_NOT_CONTAIN, HDR_ENDS_WITH, HDR_DOES_NOT_END_WITH,
        /// HDR_EQUALS, HDR_DOES_NOT_EQUAL.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhostHdrMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
