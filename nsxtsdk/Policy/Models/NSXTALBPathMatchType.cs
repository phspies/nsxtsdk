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
    /// Advanced load balancer PathMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PathMatch object")]
    public class NSXTALBPathMatchType 
    {
        /// <summary>
        /// Case sensitivity to use for the matching.
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbpathMatchMatchCaseEnumType? MatchCase { get; set; }
        /// <summary>
        /// path of the string group(s).
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_paths")]
        public IList<string> StringGroupPaths { get; set; }
        /// <summary>
        /// String values.
        /// </summary>
        [JsonProperty(PropertyName = "match_str")]
        public IList<string> MatchStr { get; set; }
        /// <summary>
        /// Criterion to use for matching the path in the HTTP request
        /// URI.
        /// Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,
        /// DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.
        /// Allowed in Basic(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)
        /// edition, Essentials(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as CONTAINS.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbpathMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
