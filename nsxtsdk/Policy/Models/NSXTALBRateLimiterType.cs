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
    /// Advanced load balancer RateLimiter object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RateLimiter object")]
    public class NSXTALBRateLimiterType 
    {
        /// <summary>
        /// Maximum number of connections, requests or packets
        /// permitted each period.
        /// Allowed values are 1-1000000000.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1000000000.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }
        /// <summary>
        /// Maximum number of connections, requests or packets to be
        /// let through instantaneously.
        /// If this is less than count, it will have no effect.
        /// Allowed values are 0-1000000000.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "burst_sz")]
        public long? BurstSz { get; set; }
        /// <summary>
        /// Identifier for Rate Limit.
        /// Constructed according to context.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Time value in seconds to enforce rate count.
        /// Allowed values are 1-1000000000.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public long? Period { get; set; }
    }
}
