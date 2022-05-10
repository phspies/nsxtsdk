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
    /// Advanced load balancer DnsPolicies object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsPolicies object")]
    public class NSXTALBDnsPoliciesType 
    {
        /// <summary>
        /// Index of the dns policy.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// path of the dns policy.
        /// It is a reference to an object of type DnsPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policy_path", Required = Required.AllowNull)]
        public string DnsPolicyPath { get; set; }
    }
}
