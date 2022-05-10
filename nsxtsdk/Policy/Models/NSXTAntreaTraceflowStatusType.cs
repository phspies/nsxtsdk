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
    /// The status value of one Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"The status value of one Antrea traceflow.")]
    public class NSXTAntreaTraceflowStatusType 
    {
        /// <summary>
        /// The execution phase of one traceflow.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaTraceflowStatusPhaseEnumType? Phase { get; set; }
        /// <summary>
        /// The reason for the failure.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
    }
}
