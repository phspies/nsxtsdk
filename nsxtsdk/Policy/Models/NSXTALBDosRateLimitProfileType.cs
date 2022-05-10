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
    /// Advanced load balancer DosRateLimitProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DosRateLimitProfile object")]
    public class NSXTALBDosRateLimitProfileType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rl_profile")]
        public NSXTALBRateLimiterProfileType RlProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dos_profile")]
        public NSXTALBDosThresholdProfileType DosProfile { get; set; }
    }
}
