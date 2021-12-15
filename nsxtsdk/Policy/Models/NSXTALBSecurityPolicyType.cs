// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Index of the network security policy to use for themitigation rules applied to the attacks.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        [NSXTDefaultProperty(Default: "")]
        public long? NetworkSecurityPolicyIndex { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only,
        /// or detect and mitigate the attacks.
        /// Enum options - DETECTION, MITIGATION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DETECTION.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Mode of dealing with the attacks - perform detection only,or detect and mitigate the attacks.Enum options - DETECTION, MITIGATION.Default value when not specified in API or module isinterpreted by ALB Controller as DETECTION.")]
        [NSXTDefaultProperty(Default: "DETECTION")]
        public NSXTAlbsecurityPolicyOperModeEnumType? OperMode { get; set; }
        /// <summary>
        /// Attacks utilizing the DNS protocol operations.
        /// </summary>
        [JsonProperty(PropertyName = "dns_attacks")]
        [NSXTProperty(IsRequired: false, Description: @"Attacks utilizing the DNS protocol operations.")]
        public NSXTALBDnsAttacksType DnsAttacks { get; set; }
        /// <summary>
        /// Index of the dns policy to use for the mitigation rules
        /// applied to the dns attacks.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policy_index")]
        [NSXTProperty(IsRequired: false, Description: @"Index of the dns policy to use for the mitigation rulesapplied to the dns attacks.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        [NSXTDefaultProperty(Default: "")]
        public long? DnsPolicyIndex { get; set; }
    }
}