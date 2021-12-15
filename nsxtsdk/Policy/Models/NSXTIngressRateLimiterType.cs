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
    public class NSXTIngressRateLimiterType : NSXTQoSBaseRateLimiterType
    {
        /// <summary>
        /// The peak bandwidth rate is used to support burst traffic.
        /// </summary>
        [JsonProperty(PropertyName = "peak_bandwidth")]
        [NSXTProperty(IsRequired: false, Description: @"The peak bandwidth rate is used to support burst traffic.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? PeakBandwidth { get; set; }
        /// <summary>
        /// You can use the average bandwidth to reduce network congestion.
        /// </summary>
        [JsonProperty(PropertyName = "average_bandwidth")]
        [NSXTProperty(IsRequired: false, Description: @"You can use the average bandwidth to reduce network congestion.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? AverageBandwidth { get; set; }
        /// <summary>
        /// The burst duration is set in the burst size setting.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        [NSXTProperty(IsRequired: false, Description: @"The burst duration is set in the burst size setting.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [NSXTDefaultProperty(Default: "")]
        public long? BurstSize { get; set; }
    }
}