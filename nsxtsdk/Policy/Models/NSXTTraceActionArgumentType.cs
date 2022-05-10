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
    public class NSXTTraceActionArgumentType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reverse_filter")]
        public NSXTLiveTraceFilterDataType ReverseFilter { get; set; }
        /// <summary>
        /// It is required only when the type of trace is bidirectional. Please keep this field aligned with the
        /// destination logical port of packet capture action config when the type of packet capture action is bidirectional.
        /// </summary>
        [JsonProperty(PropertyName = "dest_lport")]
        public string? DestLport { get; set; }
        /// <summary>
        /// Type of trace
        /// </summary>
        [JsonProperty(PropertyName = "trace_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceActionArgumentTraceTypeEnumType? TraceType { get; set; }
    }
}
