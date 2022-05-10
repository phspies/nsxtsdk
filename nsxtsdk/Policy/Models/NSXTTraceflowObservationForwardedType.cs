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
    public class NSXTTraceflowObservationForwardedType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// The name of the uplink the traceflow packet is forwarded on
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name")]
        public string? UplinkName { get; set; }
        /// <summary>
        /// The virtual tunnel endpoint label
        /// </summary>
        [JsonProperty(PropertyName = "vtep_label")]
        public long? VtepLabel { get; set; }
        /// <summary>
        /// IP address of the destination end of the tunnel
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip_address")]
        public string? RemoteIpAddress { get; set; }
        /// <summary>
        /// The 64bit tunnel context carried on the wire
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public long? Context { get; set; }
        /// <summary>
        /// IP address of the source end of the tunnel
        /// </summary>
        [JsonProperty(PropertyName = "local_ip_address")]
        public string? LocalIpAddress { get; set; }
        /// <summary>
        /// This field will not be always available. Use remote_ip_address when this field is not set.
        /// </summary>
        [JsonProperty(PropertyName = "dst_transport_node_id")]
        public string? DstTransportNodeId { get; set; }
        /// <summary>
        /// The name of the transport node to which the traceflow packet is forwarded
        /// </summary>
        [JsonProperty(PropertyName = "dst_transport_node_name")]
        public string? DstTransportNodeName { get; set; }
    }
}
