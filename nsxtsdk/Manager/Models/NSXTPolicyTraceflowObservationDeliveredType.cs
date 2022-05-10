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
    public class NSXTPolicyTraceflowObservationDeliveredType : NSXTTraceflowObservationDeliveredType
    {
        /// <summary>
        /// The path of the segment port or router port into which the traceflow packet was delivered
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        public string? SegmentPortPath { get; set; }
    }
}
