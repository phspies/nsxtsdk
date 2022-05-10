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
    /// Advanced load balancer SSLRating object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLRating object")]
    public class NSXTALBSSLRatingType 
    {
        /// <summary>
        /// Enum options - SSL_SCORE_NOT_SECURE, SSL_SCORE_VERY_BAD,
        /// SSL_SCORE_BAD, SSL_SCORE_AVERAGE, SSL_SCORE_GOOD,
        /// SSL_SCORE_EXCELLENT.
        /// </summary>
        [JsonProperty(PropertyName = "performance_rating")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslratingPerformanceRatingEnumType? PerformanceRating { get; set; }
        /// <summary>
        /// security_score of SSLRating.
        /// </summary>
        [JsonProperty(PropertyName = "security_score")]
        public string? SecurityScore { get; set; }
        /// <summary>
        /// Enum options - SSL_SCORE_NOT_SECURE, SSL_SCORE_VERY_BAD,
        /// SSL_SCORE_BAD, SSL_SCORE_AVERAGE, SSL_SCORE_GOOD,
        /// SSL_SCORE_EXCELLENT.
        /// </summary>
        [JsonProperty(PropertyName = "compatibility_rating")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslratingCompatibilityRatingEnumType? CompatibilityRating { get; set; }
    }
}
