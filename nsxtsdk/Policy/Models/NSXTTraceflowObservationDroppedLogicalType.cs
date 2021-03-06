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
    public class NSXTTraceflowObservationDroppedLogicalType : NSXTTraceflowObservationDroppedType
    {
        /// <summary>
        /// The index of service path that is a chain of services
        /// represents the point where the traceflow packet was dropped.
        /// </summary>
        [JsonProperty(PropertyName = "service_path_index")]
        public long? ServicePathIndex { get; set; }
        /// <summary>
        /// The id of the component that dropped the traceflow packet.
        /// </summary>
        [JsonProperty(PropertyName = "component_id")]
        public string? ComponentId { get; set; }
    }
}
