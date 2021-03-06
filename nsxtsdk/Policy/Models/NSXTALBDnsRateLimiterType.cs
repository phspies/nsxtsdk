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
    /// Advanced load balancer DnsRateLimiter object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRateLimiter object")]
    public class NSXTALBDnsRateLimiterType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public NSXTALBDnsRuleRLActionType Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter_object", Required = Required.AllowNull)]
        public NSXTALBRateLimiterType RateLimiterObject { get; set; }
    }
}
