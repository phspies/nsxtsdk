using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbHttpResponseHeaderConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// Value of HTTP header field
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
        public NSXTLbHttpResponseHeaderConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Name of HTTP header field
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        public string HeaderName { get; set; }
    }
}
