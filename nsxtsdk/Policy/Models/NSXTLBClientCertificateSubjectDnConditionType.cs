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
    /// Match condition for client certficate subject DN.
    /// </summary>
    [NSXTProperty(Description: @"Match condition for client certficate subject DN.")]
    public class NSXTLBClientCertificateSubjectDnConditionType 
    {
        /// <summary>
        /// If true, case is significant when comparing subject DN value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        [NSXTProperty(IsRequired: false, Description: @"If true, case is significant when comparing subject DN value.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of subject DN.
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [NSXTProperty(IsRequired: false, Description: @"Match type of subject DN.")]
        [NSXTDefaultProperty(Default: "REGEX")]
        public NSXTLbclientCertificateSubjectDnConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Value of subject DN.
        /// </summary>
        [JsonProperty(PropertyName = "subject_dn", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of subject DN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SubjectDn { get; set; }
    }
}
