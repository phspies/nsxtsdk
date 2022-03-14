// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRequestCookieConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Match type of cookie value.
        /// </summary>
        public NSXTLbhttpRequestCookieConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Cookie name.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name", Required = Required.AllowNull)]
        public string CookieName { get; set; }
        /// <summary>
        /// Cookie value.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_value", Required = Required.AllowNull)]
        public string CookieValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing cookie value.
        /// </summary>
        public bool? CaseSensitive { get; set; }
    }
}
