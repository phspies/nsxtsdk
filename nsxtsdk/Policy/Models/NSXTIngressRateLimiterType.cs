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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIngressRateLimiterType : NSXTQoSBaseRateLimiterType
    {
        /// <summary>
        /// The peak bandwidth rate is used to support burst traffic.
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth")]
        public int? PeakBandwidth { get; set; }
        /// <summary>
        /// You can use the average bandwidth to reduce network congestion.
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth")]
        public int? AverageBandwidth { get; set; }
        /// <summary>
        /// The burst duration is set in the burst size setting.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        public int? BurstSize { get; set; }
    }
}
