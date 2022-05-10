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
    public class NSXTSegmentConfigurationStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// Segment path
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        public string? SegmentPath { get; set; }
    }
}
