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
    /// Advanced load balancer RateProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RateProfile object")]
    public class NSXTALBRateProfileType 
    {
        /// <summary>
        /// HTTP header name.
        /// </summary>
        [JsonProperty(PropertyName = "http_header")]
        public string? HttpHeader { get; set; }
        /// <summary>
        /// HTTP cookie name.
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie")]
        public string? HttpCookie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public NSXTALBRateLimiterActionType Action { get; set; }
        /// <summary>
        /// Explicitly tracks an attacker across rate periods.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "explicit_tracking")]
        public bool? ExplicitTracking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter")]
        public NSXTALBRateLimiterType RateLimiter { get; set; }
        /// <summary>
        /// Enable fine granularity.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "fine_grain")]
        public bool? FineGrain { get; set; }
    }
}
