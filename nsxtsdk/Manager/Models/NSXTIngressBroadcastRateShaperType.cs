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
    public class NSXTIngressBroadcastRateShaperType : NSXTQosBaseRateShaperType
    {
        /// <summary>
        /// Average bandwidth in kb/s
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth_kbps")]
        public int? AverageBandwidthKbps { get; set; }
        /// <summary>
        /// Peak bandwidth in kb/s
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth_kbps")]
        public int? PeakBandwidthKbps { get; set; }
        /// <summary>
        /// Burst size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "burst_size_bytes")]
        public int? BurstSizeBytes { get; set; }
    }
}
