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
    public class NSXTPolicyTraceflowObservationRelayedLogicalType : NSXTTraceflowObservationRelayedLogicalType
    {
        /// <summary>
        /// This field specifies the logical component that relay service located on.
        /// </summary>
        [JsonProperty(PropertyName = "logical_component_path")]
        public string? LogicalComponentPath { get; set; }
    }
}
