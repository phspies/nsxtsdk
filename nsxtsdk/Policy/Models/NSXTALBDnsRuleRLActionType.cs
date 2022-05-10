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
    /// Advanced load balancer DnsRuleRLAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleRLAction object")]
    public class NSXTALBDnsRuleRLActionType 
    {
        /// <summary>
        /// Type of action to be enforced upon hitting the rate limit.
        /// Enum options - DNS_RL_ACTION_NONE, DNS_RL_ACTION_DROP_REQ.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_RL_ACTION_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdnsRuleRlactionTypeEnumType? Type { get; set; }
    }
}
