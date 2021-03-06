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
    /// Advanced load balancer NetworkSecurityPolicyActionRLParam object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkSecurityPolicyActionRLParam object")]
    public class NSXTALBNetworkSecurityPolicyActionRLParamType 
    {
        /// <summary>
        /// Maximum number of connections or requests or packets per
        /// second.
        /// Allowed values are 1-4294967295.
        /// </summary>
        [JsonProperty(PropertyName = "max_rate", Required = Required.AllowNull)]
        public long MaxRate { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets to be
        /// rate limited instantaneously.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size", Required = Required.AllowNull)]
        public long BurstSize { get; set; }
    }
}
