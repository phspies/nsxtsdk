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
    /// Advanced load balancer HTTPResponsePolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPResponsePolicy object")]
    public class NSXTALBHTTPResponsePolicyType 
    {
        /// <summary>
        /// Add rules to the HTTP response policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPResponseRuleType> Rules { get; set; }
    }
}
