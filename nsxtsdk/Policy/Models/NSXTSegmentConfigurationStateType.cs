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
    public class NSXTSegmentConfigurationStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// Segment path
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        [NSXTProperty(IsRequired: false, Description: @"Segment path")]
        public string? SegmentPath { get; set; }
    }
}