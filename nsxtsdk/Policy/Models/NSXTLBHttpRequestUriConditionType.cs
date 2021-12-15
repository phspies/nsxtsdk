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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRequestUriConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Match type of URI
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of URI")]
        [NSXTDefaultProperty(Default: "REGEX")]
        public NSXTLbhttpRequestUriConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// A string used to identify resource
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A string used to identify resource")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Uri { get; set; }
        /// <summary>
        /// If true, case is significant when comparing URI.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing URI.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CaseSensitive { get; set; }
    }
}
