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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyTraceflowObservationReceivedLogicalType : NSXTTraceflowObservationReceivedLogicalType
    {
        /// <summary>
        /// The path of the component that received the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "component_path")]
        public string? ComponentPath { get; set; }
        /// <summary>
        /// The path of the segment port or router port at which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        public string? SegmentPortPath { get; set; }
        /// <summary>
        /// The path of the source component from which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "src_component_path")]
        public string? SrcComponentPath { get; set; }
    }
}
