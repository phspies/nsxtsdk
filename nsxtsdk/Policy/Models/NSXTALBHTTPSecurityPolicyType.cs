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
    /// Advanced load balancer HTTPSecurityPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSecurityPolicy object")]
    public class NSXTALBHTTPSecurityPolicyType 
    {
        /// <summary>
        /// Add rules to the HTTP security policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPSecurityRuleType> Rules { get; set; }
    }
}
