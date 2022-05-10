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
    /// Advanced load balancer HTTPRequestPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPRequestPolicy object")]
    public class NSXTALBHTTPRequestPolicyType 
    {
        /// <summary>
        /// Add rules to the HTTP request policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPRequestRuleType> Rules { get; set; }
    }
}
