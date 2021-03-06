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
    /// Advanced load balancer HTTPPolicies object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPPolicies object")]
    public class NSXTALBHTTPPoliciesType 
    {
        /// <summary>
        /// Index of the virtual service HTTP policy collection.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// path of the virtual service HTTP policy collection.
        /// It is a reference to an object of type HTTPPolicySet.
        /// </summary>
        [JsonProperty(PropertyName = "http_policy_set_path", Required = Required.AllowNull)]
        public string HttpPolicySetPath { get; set; }
    }
}
