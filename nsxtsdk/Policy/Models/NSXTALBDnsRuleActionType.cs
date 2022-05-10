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
    /// Advanced load balancer DnsRuleAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleAction object")]
    public class NSXTALBDnsRuleActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pool_switching")]
        public NSXTALBDnsRuleActionPoolSwitchingType PoolSwitching { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "gslb_site_selection")]
        public NSXTALBDnsRuleActionGslbSiteSelectionType GslbSiteSelection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public NSXTALBDnsRuleActionResponseType Response { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "allow")]
        public NSXTALBDnsRuleActionAllowDropType Allow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_rate_limiter")]
        public NSXTALBDnsRateLimiterType DnsRateLimiter { get; set; }
    }
}
