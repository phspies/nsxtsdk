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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRequestUriArgumentsConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// URI arguments, aka query string of URI.
        /// </summary>
        [JsonProperty(PropertyName = "uri_arguments", Required = Required.AllowNull)]
        public string UriArguments { get; set; }
        /// <summary>
        /// Match type of URI arguments
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpRequestUriArgumentsConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// If true, case is significant when comparing URI arguments.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
    }
}
