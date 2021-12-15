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
    public class NSXTLBHttpRequestCookieConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Match type of cookie value.
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of cookie value.")]
        [NSXTDefaultProperty(Default: "REGEX")]
        public NSXTLbhttpRequestCookieConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Cookie name.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Cookie name.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CookieName { get; set; }
        /// <summary>
        /// Cookie value.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Cookie value.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CookieValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing cookie value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing cookie value.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CaseSensitive { get; set; }
    }
}