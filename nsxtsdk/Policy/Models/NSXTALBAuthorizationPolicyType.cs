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
    /// Advanced load balancer AuthorizationPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthorizationPolicy object")]
    public class NSXTALBAuthorizationPolicyType 
    {
        /// <summary>
        /// Authorization Policy Rules.
        /// </summary>
        [JsonProperty(PropertyName = "authz_rules")]
        public IList<NSXTALBAuthorizationRuleType> AuthzRules { get; set; }
    }
}
