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
    /// Advanced load balancer NetworkSecurityRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkSecurityRule object")]
    public class NSXTALBNetworkSecurityRuleType 
    {
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Placeholder for description of property enable of obj type
        /// NetworkSecurityRule field type str  type boolean.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        public bool Enable { get; set; }
        /// <summary>
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Enum options - NETWORK_SECURITY_POLICY_ACTION_TYPE_ALLOW,
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY,
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_RATE_LIMIT.
        /// Allowed in Basic(Allowed values-
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY) edition,
        /// Essentials(Allowed values-
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbnetworkSecurityRuleActionEnumType Action { get; set; }
        /// <summary>
        /// Time in minutes after which rule will be deleted.
        /// Allowed values are 1-4294967295.
        /// Special values are 0- 'blocked for ever'.
        /// Unit is MIN.
        /// Allowed in Basic(Allowed values- 0) edition,
        /// Essentials(Allowed values- 0) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public long? Age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rl_param")]
        public NSXTALBNetworkSecurityPolicyActionRLParamType RlParam { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match", Required = Required.AllowNull)]
        public NSXTALBNetworkSecurityMatchTargetType Match { get; set; }
    }
}
