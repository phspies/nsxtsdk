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
    public class NSXTTraceflowObservationReceivedLogicalType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// MAC address of SAN volume controller for service insertion(SI)
        /// in service VM(SVM) where the traceflow packet was received.
        /// </summary>
        [JsonProperty(PropertyName = "svc_mac")]
        public string? SvcMac { get; set; }
        /// <summary>
        /// The id of the source component from which the traceflow packet was received.
        /// </summary>
        [JsonProperty(PropertyName = "src_component_id")]
        public string? SrcComponentId { get; set; }
        /// <summary>
        /// The id of the component that received the traceflow packet.
        /// </summary>
        [JsonProperty(PropertyName = "component_id")]
        public string? ComponentId { get; set; }
        /// <summary>
        /// The id of the logical port at which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        public string? LportId { get; set; }
        /// <summary>
        /// The type of the source component from which the traceflow packet was received.
        /// </summary>
        [JsonProperty(PropertyName = "src_component_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationReceivedLogicalSrcComponentTypeEnumType? SrcComponentType { get; set; }
        /// <summary>
        /// The name of the logical port at which the traceflow packet was received
        /// </summary>
        [JsonProperty(PropertyName = "lport_name")]
        public string? LportName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet was received by a VLAN
        /// logical network.
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
        /// <summary>
        /// The name of source component from which the traceflow packet was received.
        /// </summary>
        [JsonProperty(PropertyName = "src_component_name")]
        public string? SrcComponentName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet was received by an overlay
        /// logical network.
        /// </summary>
        [JsonProperty(PropertyName = "vni")]
        public int? Vni { get; set; }
    }
}
