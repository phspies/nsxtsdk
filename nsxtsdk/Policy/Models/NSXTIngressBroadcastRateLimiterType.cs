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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIngressBroadcastRateLimiterType : NSXTQoSBaseRateLimiterType
    {
        /// <summary>
        /// Peak bandwidth in kb/s
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth")]
        [NSXTProperty(IsRequired: false, Description: @"Peak bandwidth in kb/s")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? PeakBandwidth { get; set; }
        /// <summary>
        /// Average bandwidth in kb/s
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth")]
        [NSXTProperty(IsRequired: false, Description: @"Average bandwidth in kb/s")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? AverageBandwidth { get; set; }
        /// <summary>
        /// Burst size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        [NSXTProperty(IsRequired: false, Description: @"Burst size in bytes")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? BurstSize { get; set; }
    }
}