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
    public class NSXTPolicyTraceflowObservationDeliveredType : NSXTTraceflowObservationDeliveredType
    {
        /// <summary>
        /// The path of the segment port or router port into which the traceflow packet was delivered
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the segment port or router port into which the traceflow packet was delivered")]
        public string? SegmentPortPath { get; set; }
    }
}
