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
        [NSXTProperty(IsRequired: false, Description: @"Indicates whether duplicate IP detection should be enabled")]
        public bool? DuplicateIpDetectionEnabled { get; set; }
    }
}