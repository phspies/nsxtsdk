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
    public class NSXTLbHttpRequestCookieConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// Match type of cookie value
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpRequestCookieConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Name of cookie
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name", Required = Required.AllowNull)]
        public string CookieName { get; set; }
        /// <summary>
        /// Value of cookie
        /// </summary>
        [JsonProperty(PropertyName = "cookie_value", Required = Required.AllowNull)]
        public string CookieValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing cookie value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
    }
}
