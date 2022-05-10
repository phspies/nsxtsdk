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
    public class NSXTEgressRateLimiterType : NSXTQoSBaseRateLimiterType
    {
        /// <summary>
        /// Peak bandwidth in Mb/s
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth")]
        public int? PeakBandwidth { get; set; }
        /// <summary>
        /// Average bandwidth in Mb/s
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth")]
        public int? AverageBandwidth { get; set; }
        /// <summary>
        /// Burst size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        public int? BurstSize { get; set; }
    }
}
