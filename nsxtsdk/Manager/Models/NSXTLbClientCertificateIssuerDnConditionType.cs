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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Match condition for client certficate issuer DN
    /// </summary>
    [NSXTProperty(Description: @"Match condition for client certficate issuer DN")]
    public class NSXTLbClientCertificateIssuerDnConditionType 
    {
        public NSXTLbClientCertificateIssuerDnConditionType()
        {
            CaseSensitive = test
            MatchType = test
        }
        /// <summary>
        /// If true, case is significant when comparing issuer DN value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing issuer DN value.")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of issuer DN
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of issuer DN")]
        public NSXTLbClientCertificateIssuerDnConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Value of issuer DN
        /// </summary>
        [JsonProperty(PropertyName = "issuer_dn", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of issuer DN")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IssuerDn { get; set; }
    }
}
