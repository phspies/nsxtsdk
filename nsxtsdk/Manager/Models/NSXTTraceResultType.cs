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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTraceResultType 
    {
        /// <summary>
        /// Direction of a trace
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [NSXTProperty(IsRequired: false, Description: @"Direction of a trace")]
        public NSXTTraceResultDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Observation counters for logical components
        /// </summary>
        [JsonProperty(PropertyName = "logical_counters")]
        [NSXTProperty(IsRequired: false, Description: @"Observation counters for logical components")]
        public NSXTTraceflowObservationCountersType LogicalCounters { get; set; }
        /// <summary>
        /// Trace observation list
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        [NSXTProperty(IsRequired: false, Description: @"Trace observation list")]
        public IList<NSXTTraceflowObservationType> Observations { get; set; }
        /// <summary>
        /// Packet ID in the session
        /// </summary>
        [JsonProperty(PropertyName = "packet_id")]
        [NSXTProperty(IsRequired: false, Description: @"Packet ID in the session")]
        public string? PacketId { get; set; }
        /// <summary>
        /// Whether some observations were deleted from the result set
        /// </summary>
        [JsonProperty(PropertyName = "result_overflowed")]
        [NSXTProperty(IsRequired: false, Description: @"Whether some observations were deleted from the result set")]
        public bool? ResultOverflowed { get; set; }
        /// <summary>
        /// Trace action result analysis notes
        /// </summary>
        [JsonProperty(PropertyName = "analysis")]
        [NSXTProperty(IsRequired: false, Description: @"Trace action result analysis notes")]
        public IList<string> Analysis { get; set; }
        /// <summary>
        /// Observation counters
        /// </summary>
        [JsonProperty(PropertyName = "counters")]
        [NSXTProperty(IsRequired: false, Description: @"Observation counters")]
        public NSXTTraceflowObservationCountersType Counters { get; set; }
    }
}