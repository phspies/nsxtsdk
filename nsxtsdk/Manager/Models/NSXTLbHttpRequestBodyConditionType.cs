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
    public class NSXTLbHttpRequestBodyConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// HTTP request body
        /// </summary>
        [JsonProperty(PropertyName = "body_value", Required = Required.AllowNull)]
        public string BodyValue { get; set; }
        /// <summary>
        /// Match type of HTTP body
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpRequestBodyConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// If true, case is significant when comparing HTTP body value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
    }
}
