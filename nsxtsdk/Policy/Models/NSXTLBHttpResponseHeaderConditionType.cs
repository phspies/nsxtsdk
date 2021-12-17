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
    public class NSXTLBHttpResponseHeaderConditionType : NSXTLBRuleConditionType
    {
        public NSXTLBHttpResponseHeaderConditionType()
        {
            CaseSensitive = test
            MatchType = test
        }
        /// <summary>
        /// Value of HTTP header field
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of HTTP header field")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing HTTP header value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing HTTP header value.")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of HTTP header value
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of HTTP header value")]
        public NSXTLbhttpResponseHeaderConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Name of HTTP header field
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of HTTP header field")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HeaderName { get; set; }
    }
}
