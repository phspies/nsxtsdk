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
    /// Packet data stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Packet data stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowPacketDataType 
    {
        public NSXTAntreaTraceflowPacketDataType()
        {
        }
        /// <summary>
        /// This property is used to set transport type.
        /// </summary>
        [JsonProperty(PropertyName = "transportType")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to set transport type.")]
        public NSXTAntreaTraceflowPacketDataTransportTypeEnumType? TransportType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipHeader")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTAntreaTraceflowIpHeaderType IpHeader { get; set; }
        /// <summary>
        /// This property is used to set packet data size.
        /// </summary>
        [JsonProperty(PropertyName = "frameSize")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to set packet data size.")]
        public long? FrameSize { get; set; }
        /// <summary>
        /// This property is used to set resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to set resource type.")]
        public NSXTAntreaTraceflowPacketDataResourceTypeEnumType? ResourceType { get; set; }
        /// <summary>
        /// This property is used to set payload data.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to set payload data.")]
        public string? Payload { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Header")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTAntreaTraceflowIpv6HeaderType Ipv6Header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transportHeader")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTAntreaTraceflowTransportHeaderType TransportHeader { get; set; }
    }
}