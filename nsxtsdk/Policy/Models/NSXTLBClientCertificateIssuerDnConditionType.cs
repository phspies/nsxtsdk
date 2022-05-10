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
    /// Match condition for client certficate issuer DN.
    /// </summary>
    [NSXTProperty(Description: @"Match condition for client certficate issuer DN.")]
    public class NSXTLBClientCertificateIssuerDnConditionType 
    {
        /// <summary>
        /// If true, case is significant when comparing issuer DN value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of issuer DN.
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbclientCertificateIssuerDnConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Value of issuer DN.
        /// </summary>
        [JsonProperty(PropertyName = "issuer_dn", Required = Required.AllowNull)]
        public string IssuerDn { get; set; }
    }
}
