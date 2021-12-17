// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Observation result for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Observation result for Antrea traceflow.")]
    public class NSXTAntreaTraceflowObservationType 
    {
        public NSXTAntreaTraceflowObservationType()
        {
        }
        /// <summary>
        /// Timestamp when the observation was collect by Antrea controller.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the observation was collect by Antrea controller.")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// UID of the container node that observed a traceflow packet.
        /// </summary>
        [JsonProperty(PropertyName = "container_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"UID of the container node that observed a traceflow packet.")]
        public string? ContainerNodeId { get; set; }
        /// <summary>
        /// The type of component.
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        [NSXTProperty(IsRequired: false, Description: @"The type of component.")]
        public NSXTAntreaTraceflowObservationComponentTypeEnumType? ComponentType { get; set; }
        /// <summary>
        /// The type of observation.
        /// AntreaTraceflowObservationDelivered: The packet was delivered to destination Pod properly
        /// AntreaTraceflowObservationReceived: The packet was received from another ContainerNode
        /// AntreaTraceflowObservationForwarded: The packet was forwarded to next logical node or ContainerNode
        /// AntreaTraceflowObservationDropped: The packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "observation_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The type of observation.AntreaTraceflowObservationDelivered: The packet was delivered to destination Pod properlyAntreaTraceflowObservationReceived: The packet was received from another ContainerNodeAntreaTraceflowObservationForwarded: The packet was forwarded to next logical node or ContainerNodeAntreaTraceflowObservationDropped: The packet was dropped")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAntreaTraceflowObservationObservationTypeEnumType ObservationType { get; set; }
    }
}