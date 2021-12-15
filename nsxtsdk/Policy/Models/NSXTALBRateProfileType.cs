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
    /// Advanced load balancer RateProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RateProfile object")]
    public class NSXTALBRateProfileType 
    {
        /// <summary>
        /// HTTP header name.
        /// </summary>
        [JsonProperty(PropertyName = "http_header")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP header name.")]
        public string? HttpHeader { get; set; }
        /// <summary>
        /// HTTP cookie name.
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP cookie name.")]
        public string? HttpCookie { get; set; }
        /// <summary>
        /// Action to perform upon rate limiting.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Action to perform upon rate limiting.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRateLimiterActionType Action { get; set; }
        /// <summary>
        /// Explicitly tracks an attacker across rate periods.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "explicit_tracking")]
        [NSXTProperty(IsRequired: false, Description: @"Explicitly tracks an attacker across rate periods.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? ExplicitTracking { get; set; }
        /// <summary>
        /// The rate limiter configuration for this rate profile.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter")]
        [NSXTProperty(IsRequired: false, Description: @"The rate limiter configuration for this rate profile.")]
        public NSXTALBRateLimiterType RateLimiter { get; set; }
        /// <summary>
        /// Enable fine granularity.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "fine_grain")]
        [NSXTProperty(IsRequired: false, Description: @"Enable fine granularity.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? FineGrain { get; set; }
    }
}