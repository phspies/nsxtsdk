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
    /// Aggregate of DNS forwarder nslookup answer across enforcement points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of DNS forwarder nslookup answer across enforcement points.")]
    public class NSXTAggregatePolicyDnsAnswerType 
    {
        /// <summary>
        /// List of DNS forwarder nslookup answer per enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "dns_answer_per_enforcement_point")]
        [NSXTProperty(IsRequired: false, Description: @"List of DNS forwarder nslookup answer per enforcement point.")]
        public IList<NSXTPolicyDnsAnswerPerEnforcementPointType> DnsAnswerPerEnforcementPoint { get; set; }
        /// <summary>
        /// String path of the DNS forwarder intent.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"String path of the DNS forwarder intent.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IntentPath { get; set; }
    }
}
