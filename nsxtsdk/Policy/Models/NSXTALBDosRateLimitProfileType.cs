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
        public NSXTALBDosRateLimitProfileType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rl_profile")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBRateLimiterProfileType RlProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dos_profile")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBDosThresholdProfileType DosProfile { get; set; }
    }
}
