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
    /// Aggregate of DNS forwarder nslookup answer across enforcement points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of DNS forwarder nslookup answer across enforcement points.")]
    public class NSXTAggregatePolicyDnsAnswerType 
    {
        /// <summary>
        /// List of DNS forwarder nslookup answer per enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "dns_answer_per_enforcement_point")]
        public IList<NSXTPolicyDnsAnswerPerEnforcementPointType> DnsAnswerPerEnforcementPoint { get; set; }
        /// <summary>
        /// String path of the DNS forwarder intent.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        public string IntentPath { get; set; }
    }
}
