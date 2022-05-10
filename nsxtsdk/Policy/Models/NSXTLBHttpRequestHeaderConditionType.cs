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
    public class NSXTLBHttpRequestHeaderConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Value of HTTP header
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        public string HeaderValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing HTTP header value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of HTTP header value
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpRequestHeaderConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Name of HTTP header
        /// </summary>
        [JsonProperty(PropertyName = "header_name")]
        public string? HeaderName { get; set; }
    }
}
