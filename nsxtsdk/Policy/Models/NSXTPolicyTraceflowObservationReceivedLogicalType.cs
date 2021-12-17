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
    public class NSXTPolicyTraceflowObservationReceivedLogicalType : NSXTTraceflowObservationReceivedLogicalType
    {
        public NSXTPolicyTraceflowObservationReceivedLogicalType()
        {
        }
        /// <summary>
        /// The path of the component that received the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "component_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the component that received the traceflow packet")]
        public string? ComponentPath { get; set; }
        /// <summary>
        /// The path of the segment port or router port at which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the segment port or router port at which the traceflow packet was received")]
        public string? SegmentPortPath { get; set; }
        /// <summary>
        /// The path of the source component from which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "src_component_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the source component from which the traceflow packet was received")]
        public string? SrcComponentPath { get; set; }
    }
}
