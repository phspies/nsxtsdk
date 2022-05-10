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
    /// Contains dupliacte IP detection related discovery options.
    /// </summary>
    [NSXTProperty(Description: @"Contains dupliacte IP detection related discovery options.")]
    public class NSXTDuplicateIPDetectionOptionsType 
    {
        /// <summary>
        /// Indicates whether duplicate IP detection should be enabled
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_ip_detection_enabled")]
        public bool? DuplicateIpDetectionEnabled { get; set; }
    }
}
