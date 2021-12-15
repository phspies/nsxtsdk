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
    /// Advanced load balancer L4RuleProtocolMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RuleProtocolMatch object")]
    public class NSXTALBL4RuleProtocolMatchType 
    {
        /// <summary>
        /// Transport protocol to match.
        /// Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Transport protocol to match.Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBL4RuleProtocolMatchProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Criterion to use for transport protocol matching.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for transport protocol matching.Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBL4RuleProtocolMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
