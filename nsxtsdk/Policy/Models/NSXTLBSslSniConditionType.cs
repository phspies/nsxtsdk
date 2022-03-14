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
    public class NSXTLBSslSniConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// If true, case is significant when comparing SNI value.
        /// </summary>
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of SNI
        /// </summary>
        public NSXTLbsslSniConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// The SNI(Server Name indication) in client hello message.
        /// </summary>
        [JsonProperty(PropertyName = "sni", Required = Required.AllowNull)]
        public string Sni { get; set; }
    }
}
