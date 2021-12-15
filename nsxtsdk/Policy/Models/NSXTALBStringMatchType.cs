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
    /// Advanced load balancer StringMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer StringMatch object")]
    public class NSXTALBStringMatchType 
    {
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
        /// Criterion to use for string matching the HTTP request.
        /// Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,
        /// DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for string matching the HTTP request.Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbstringMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
