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
    /// Advanced load balancer RateLimiterProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RateLimiterProfile object")]
    public class NSXTALBRateLimiterProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uri_failed_requests_rate_limit")]
        public NSXTALBRateProfileType UriFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_scanners_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpScannersRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "custom_requests_rate_limit")]
        public NSXTALBRateProfileType CustomRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_to_uri_failed_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpToUriFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_to_uri_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpToUriRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_failed_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uri_requests_rate_limit")]
        public NSXTALBRateProfileType UriRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "uri_scanners_requests_rate_limit")]
        public NSXTALBRateProfileType UriScannersRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpRequestsRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_connections_rate_limit")]
        public NSXTALBRateProfileType ClientIpConnectionsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests from all client IP addresses
        /// that contain any single HTTP header value.
        /// </summary>
        [JsonProperty(PropertyName = "http_header_rate_limits")]
        public IList<NSXTALBRateProfileType> HttpHeaderRateLimits { get; set; }
    }
}
