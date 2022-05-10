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
    /// Advanced load balancer AuthenticationPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthenticationPolicy object")]
    public class NSXTALBAuthenticationPolicyType 
    {
        /// <summary>
        /// Auth Profile to use for validating users.
        /// It is a reference to an object of type AuthProfile.
        /// </summary>
        [JsonProperty(PropertyName = "default_auth_profile_path", Required = Required.AllowNull)]
        public string DefaultAuthProfilePath { get; set; }
        /// <summary>
        /// Add rules to apply auth profile to specific targets.
        /// </summary>
        [JsonProperty(PropertyName = "authn_rules")]
        public IList<NSXTALBAuthenticationRuleType> AuthnRules { get; set; }
    }
}
