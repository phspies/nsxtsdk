// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public int? PeakBandwidth { get; set; }
        /// <summary>
        /// Average bandwidth in Mb/s
        /// </summary>
        public int? AverageBandwidth { get; set; }
        /// <summary>
        /// Burst size in bytes
        /// </summary>
        public int? BurstSize { get; set; }
    }
}
