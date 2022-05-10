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
    /// Configuration of livetrace packet granular action
    /// </summary>
    [NSXTProperty(Description: @"Configuration of livetrace packet granular action")]
    public class NSXTLiveTracePacketGranularActionConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reverse_filter")]
        public NSXTLiveTraceFilterDataType ReverseFilter { get; set; }
        /// <summary>
        /// Type of trace
        /// </summary>
        [JsonProperty(PropertyName = "trace_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLiveTracePacketGranularActionConfigTraceTypeEnumType TraceType { get; set; }
        /// <summary>
        /// Policy path of logical port for the reverse direction of a livetrace session. It is required only when the
        /// trace type is bidirectional. Multiple bi-directional actions in a livetrace session should have the same
        /// port specified for the reverse direction.
        /// </summary>
        [JsonProperty(PropertyName = "dest_port_path")]
        public string? DestPortPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sampling", Required = Required.AllowNull)]
        public NSXTLiveTraceSamplingConfigType Sampling { get; set; }
    }
}
