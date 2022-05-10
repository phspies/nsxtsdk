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
    /// Match condition for client certficate subject DN.
    /// </summary>
    [NSXTProperty(Description: @"Match condition for client certficate subject DN.")]
    public class NSXTLBClientCertificateSubjectDnConditionType 
    {
        /// <summary>
        /// If true, case is significant when comparing subject DN value.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of subject DN.
        /// </summary>
        [JsonProperty(PropertyName = "match_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbclientCertificateSubjectDnConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Value of subject DN.
        /// </summary>
        [JsonProperty(PropertyName = "subject_dn", Required = Required.AllowNull)]
        public string SubjectDn { get; set; }
    }
}
