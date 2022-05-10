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
    public class NSXTLBSslSniConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// If true, case is significant when comparing SNI value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of SNI
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbsslSniConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// The SNI(Server Name indication) in client hello message.
        /// </summary>
        [JsonProperty(PropertyName = "sni", Required = Required.AllowNull)]
        public string Sni { get; set; }
    }
}
