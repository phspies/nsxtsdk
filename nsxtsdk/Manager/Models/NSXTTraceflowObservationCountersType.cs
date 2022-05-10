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
    public class NSXTTraceflowObservationCountersType 
    {
        /// <summary>
        /// Total number of forwarded observations for this traceflow round.
        /// </summary>
        [JsonProperty(PropertyName = "forwarded_count")]
        public long? ForwardedCount { get; set; }
        /// <summary>
        /// Total number of dropped observations for this round.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_count")]
        public long? DroppedCount { get; set; }
        /// <summary>
        /// Total number of delivered observations for this traceflow round.
        /// </summary>
        [JsonProperty(PropertyName = "delivered_count")]
        public long? DeliveredCount { get; set; }
        /// <summary>
        /// Total number of received observations for this traceflow round.
        /// </summary>
        [JsonProperty(PropertyName = "received_count")]
        public long? ReceivedCount { get; set; }
    }
}
