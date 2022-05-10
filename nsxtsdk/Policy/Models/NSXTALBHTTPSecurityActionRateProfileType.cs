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
    /// Advanced load balancer HTTPSecurityActionRateProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSecurityActionRateProfile object")]
    public class NSXTALBHTTPSecurityActionRateProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public NSXTALBRateLimiterActionType Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter", Required = Required.AllowNull)]
        public NSXTALBRateLimiterType RateLimiter { get; set; }
        /// <summary>
        /// Rate limiting should be done on a per request uri path
        /// basis.
        /// </summary>
        [JsonProperty(PropertyName = "per_uri_path")]
        public bool? PerUriPath { get; set; }
        /// <summary>
        /// Rate limiting should be done on a per client ip basis.
        /// </summary>
        [JsonProperty(PropertyName = "per_client_ip")]
        public bool? PerClientIp { get; set; }
    }
}
