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
    /// Observation result for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Observation result for Antrea traceflow.")]
    public class NSXTAntreaTraceflowObservationType 
    {
        /// <summary>
        /// Timestamp when the observation was collect by Antrea controller.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// UID of the container node that observed a traceflow packet.
        /// </summary>
        [JsonProperty(PropertyName = "container_node_id")]
        public string? ContainerNodeId { get; set; }
        /// <summary>
        /// The type of component.
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaTraceflowObservationComponentTypeEnumType? ComponentType { get; set; }
        /// <summary>
        /// The type of observation.
        /// AntreaTraceflowObservationDelivered: The packet was delivered to destination Pod properly
        /// AntreaTraceflowObservationReceived: The packet was received from another ContainerNode
        /// AntreaTraceflowObservationForwarded: The packet was forwarded to next logical node or ContainerNode
        /// AntreaTraceflowObservationDropped: The packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "observation_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaTraceflowObservationObservationTypeEnumType ObservationType { get; set; }
    }
}
