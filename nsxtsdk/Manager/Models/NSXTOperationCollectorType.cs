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
    /// The operation collector is defined to receive stats from hosts. (eg. vRNI-collector collects all the system metrics)
    /// </summary>
    [NSXTProperty(Description: @"The operation collector is defined to receive stats from hosts. (eg. vRNI-collector collects all the system metrics)")]
    public class NSXTOperationCollectorType 
    {
        /// <summary>
        /// Port for the operation collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_port", Required = Required.AllowNull)]
        public int CollectorPort { get; set; }
        /// <summary>
        /// Port for the Wavefront tracing.
        /// </summary>
        [JsonProperty(PropertyName = "tracing_port")]
        public int? TracingPort { get; set; }
        /// <summary>
        /// Define the operation collector type.
        /// </summary>
        [JsonProperty(PropertyName = "collector_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTOperationCollectorCollectorTypeEnumType? CollectorType { get; set; }
        /// <summary>
        /// IP address for the operation collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip", Required = Required.AllowNull)]
        public string CollectorIp { get; set; }
    }
}
