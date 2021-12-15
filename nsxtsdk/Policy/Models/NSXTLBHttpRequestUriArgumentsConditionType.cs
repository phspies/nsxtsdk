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
    public class NSXTLBHttpRequestUriArgumentsConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// URI arguments, aka query string of URI.
        /// </summary>
        [JsonProperty(PropertyName = "uri_arguments", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"URI arguments, aka query string of URI.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string UriArguments { get; set; }
        /// <summary>
        /// Match type of URI arguments
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of URI arguments")]
        [NSXTDefaultProperty(Default: "REGEX")]
        public NSXTLbhttpRequestUriArgumentsConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// If true, case is significant when comparing URI arguments.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing URI arguments.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CaseSensitive { get; set; }
    }
}