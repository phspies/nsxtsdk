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
    /// Packet data stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Packet data stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowPacketDataType 
    {
        /// <summary>
        /// This property is used to set transport type.
        /// </summary>
        [JsonProperty(PropertyName = "transportType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaTraceflowPacketDataTransportTypeEnumType? TransportType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipHeader")]
        public NSXTAntreaTraceflowIpHeaderType IpHeader { get; set; }
        /// <summary>
        /// This property is used to set packet data size.
        /// </summary>
        [JsonProperty(PropertyName = "frameSize")]
        public long? FrameSize { get; set; }
        /// <summary>
        /// This property is used to set resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaTraceflowPacketDataResourceTypeEnumType? ResourceType { get; set; }
        /// <summary>
        /// This property is used to set payload data.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public string? Payload { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Header")]
        public NSXTAntreaTraceflowIpv6HeaderType Ipv6Header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transportHeader")]
        public NSXTAntreaTraceflowTransportHeaderType TransportHeader { get; set; }
    }
}
