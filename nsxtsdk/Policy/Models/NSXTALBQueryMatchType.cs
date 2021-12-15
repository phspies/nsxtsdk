// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer QueryMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer QueryMatch object")]
    public class NSXTALBQueryMatchType 
    {
        /// <summary>
        /// Case sensitivity to use for the match.
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [NSXTProperty(IsRequired: false, Description: @"Case sensitivity to use for the match.Enum options - SENSITIVE, INSENSITIVE.Default value when not specified in API or module isinterpreted by ALB Controller as INSENSITIVE.")]
        [NSXTDefaultProperty(Default: "INSENSITIVE")]
        public NSXTAlbqueryMatchMatchCaseEnumType? MatchCase { get; set; }
        /// <summary>
        /// path of the string group(s).
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_paths")]
        [NSXTProperty(IsRequired: false, Description: @"path of the string group(s).It is a reference to an object of type StringGroup.")]
        public IList<string> StringGroupPaths { get; set; }
        /// <summary>
        /// String value(s).
        /// </summary>
        [JsonProperty(PropertyName = "match_str")]
        [NSXTProperty(IsRequired: false, Description: @"String value(s).")]
        public IList<string> MatchStr { get; set; }
        /// <summary>
        /// Criterion to use for matching the query in HTTP request
        /// URI.
        /// Enum options - QUERY_MATCH_CONTAINS.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for matching the query in HTTP requestURI.Enum options - QUERY_MATCH_CONTAINS.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbqueryMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
