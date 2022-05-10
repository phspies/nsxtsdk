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
    public class NSXTNodeServiceStatusPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Reason for service degradation
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Service health in addition to runtime_state
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeServiceStatusPropertiesHealthEnumType? Health { get; set; }
        /// <summary>
        /// Service monitor process id
        /// </summary>
        [JsonProperty(PropertyName = "monitor_pid")]
        public long? MonitorPid { get; set; }
        /// <summary>
        /// Service process ids
        /// </summary>
        [JsonProperty(PropertyName = "pids")]
        public long? Pids { get; set; }
        /// <summary>
        /// Service runtime state
        /// </summary>
        [JsonProperty(PropertyName = "runtime_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeServiceStatusPropertiesRuntimeStateEnumType? RuntimeState { get; set; }
        /// <summary>
        /// Service monitor runtime state
        /// </summary>
        [JsonProperty(PropertyName = "monitor_runtime_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeServiceStatusPropertiesMonitorRuntimeStateEnumType? MonitorRuntimeState { get; set; }
    }
}
