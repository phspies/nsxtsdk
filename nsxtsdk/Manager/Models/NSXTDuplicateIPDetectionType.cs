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
    /// Duplicate IP detection and control
    /// </summary>
    [NSXTProperty(Description: @"Duplicate IP detection and control")]
    public class NSXTDuplicateIPDetectionType 
    {
        /// <summary>
        /// Indicates whether duplicate IP detection should be enabled
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_ip_detection_enabled")]
        public bool? DuplicateIpDetectionEnabled { get; set; }
    }
}
