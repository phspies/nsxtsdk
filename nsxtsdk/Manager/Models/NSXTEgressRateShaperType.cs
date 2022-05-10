using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEgressRateShaperType : NSXTQosBaseRateShaperType
    {
        /// <summary>
        /// Average bandwidth in Mb/s
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth_mbps")]
        public int? AverageBandwidthMbps { get; set; }
        /// <summary>
        /// Peak bandwidth in Mb/s
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth_mbps")]
        public int? PeakBandwidthMbps { get; set; }
        /// <summary>
        /// Burst size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "burst_size_bytes")]
        public int? BurstSizeBytes { get; set; }
    }
}
