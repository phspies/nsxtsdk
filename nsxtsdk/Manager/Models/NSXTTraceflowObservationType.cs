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
    public class NSXTTraceflowObservationType 
    {
        /// <summary>
        /// Timestamp when the observation was created by the transport node (microseconds epoch)
        /// </summary>
        [JsonProperty(PropertyName = "timestamp_micro")]
        public long? TimestampMicro { get; set; }
        /// <summary>
        /// The sub type of the component that issued the observation.
        /// </summary>
        [JsonProperty(PropertyName = "component_sub_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationComponentSubTypeEnumType? ComponentSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// The type of the component that issued the observation.
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationComponentTypeEnumType? ComponentType { get; set; }
        /// <summary>
        /// name of the transport node that observed a traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_name")]
        public string? TransportNodeName { get; set; }
        /// <summary>
        /// Timestamp when the observation was created by the transport node (milliseconds epoch)
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// id of the transport node that observed a traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
        /// <summary>
        /// the hop count for observations on the transport node that a traceflow packet is injected in will be 0. The hop count is
        /// incremented each time a subsequent transport node receives the traceflow packet. The sequence number of 999 indicates
        /// that the hop count could not be determined for the containing observation.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_no")]
        public long? SequenceNo { get; set; }
        /// <summary>
        /// type of the transport node that observed a traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationTransportNodeTypeEnumType? TransportNodeType { get; set; }
        /// <summary>
        /// The name of the component that issued the observation.
        /// </summary>
        [JsonProperty(PropertyName = "component_name")]
        public string? ComponentName { get; set; }
    }
}
