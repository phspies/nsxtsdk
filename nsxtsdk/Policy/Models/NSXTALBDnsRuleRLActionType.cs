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
    /// Advanced load balancer DnsRuleRLAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleRLAction object")]
    public class NSXTALBDnsRuleRLActionType 
    {
        public NSXTALBDnsRuleRLActionType()
        {
            Type = test
        }
        /// <summary>
        /// Type of action to be enforced upon hitting the rate limit.
        /// Enum options - DNS_RL_ACTION_NONE, DNS_RL_ACTION_DROP_REQ.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_RL_ACTION_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of action to be enforced upon hitting the rate limit.Enum options - DNS_RL_ACTION_NONE, DNS_RL_ACTION_DROP_REQ.Default value when not specified in API or module isinterpreted by ALB Controller as DNS_RL_ACTION_NONE.")]
        public NSXTAlbdnsRuleRlactionTypeEnumType? Type { get; set; }
    }
}
