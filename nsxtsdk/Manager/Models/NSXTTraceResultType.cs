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
    public class NSXTTraceResultType 
    {
        /// <summary>
        /// Direction of a trace
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceResultDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_counters")]
        public NSXTTraceflowObservationCountersType LogicalCounters { get; set; }
        /// <summary>
        /// Trace observation list
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        public IList<NSXTTraceflowObservationType> Observations { get; set; }
        /// <summary>
        /// Packet ID in the session
        /// </summary>
        [JsonProperty(PropertyName = "packet_id")]
        public string? PacketId { get; set; }
        /// <summary>
        /// Whether some observations were deleted from the result set
        /// </summary>
        [JsonProperty(PropertyName = "result_overflowed")]
        public bool? ResultOverflowed { get; set; }
        /// <summary>
        /// Trace action result analysis notes
        /// </summary>
        [JsonProperty(PropertyName = "analysis")]
        public IList<string> Analysis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "counters")]
        public NSXTTraceflowObservationCountersType Counters { get; set; }
    }
}
