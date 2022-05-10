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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBSecurityPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Index of the network security policy to use for the
        /// mitigation rules applied to the attacks.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "network_security_policy_index")]
        public long? NetworkSecurityPolicyIndex { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only,
        /// or detect and mitigate the attacks.
        /// Enum options - DETECTION, MITIGATION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DETECTION.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsecurityPolicyOperModeEnumType? OperMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_attacks")]
        public NSXTALBDnsAttacksType DnsAttacks { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Index of the dns policy to use for the mitigation rules
        /// applied to the dns attacks.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policy_index")]
        public long? DnsPolicyIndex { get; set; }
    }
}
