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
    /// Advanced load balancer DosRateLimitProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DosRateLimitProfile object")]
    public class NSXTALBDosRateLimitProfileType 
    {
        /// <summary>
        /// Profile for Connections/Requests rate limiting.
        /// </summary>
        [JsonProperty(PropertyName = "rl_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Profile for Connections/Requests rate limiting.")]
        public NSXTALBRateLimiterProfileType RlProfile { get; set; }
        /// <summary>
        /// Profile for DoS attack detection.
        /// </summary>
        [JsonProperty(PropertyName = "dos_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Profile for DoS attack detection.")]
        public NSXTALBDosThresholdProfileType DosProfile { get; set; }
    }
}