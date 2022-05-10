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
    public class NSXTTraceflowConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Timeout for traceflow observation results
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// This field indicates if intent is transient and will be cleaned up by the system if set to true
        /// </summary>
        [JsonProperty(PropertyName = "is_transient")]
        public bool? IsTransient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "packet", Required = Required.AllowNull)]
        public NSXTPacketDataType Packet { get; set; }
        /// <summary>
        /// Segment Port Path or UUID
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path", Required = Required.AllowNull)]
        public string SegmentPortPath { get; set; }
    }
}
