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
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTALBL4RuleProtocolMatchProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Criterion to use for transport protocol matching.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTALBL4RuleProtocolMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
