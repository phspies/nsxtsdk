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
    public class NSXTPortSecurityProfileBindingMapType : NSXTSecurityProfileBindingMapType
    {
        /// <summary>
        /// The policy path of the asscociated SpoofGuard profile
        /// </summary>
        [JsonProperty(PropertyName = "spoofguard_profile_path")]
        public string? SpoofguardProfilePath { get; set; }
        /// <summary>
        /// The policy path of the asscociated Segment Security profile
        /// </summary>
        [JsonProperty(PropertyName = "segment_security_profile_path")]
        public string? SegmentSecurityProfilePath { get; set; }
    }
}
