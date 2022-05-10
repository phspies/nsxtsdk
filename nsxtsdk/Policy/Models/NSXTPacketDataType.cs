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
    public class NSXTPacketDataType 
    {
        /// <summary>
        /// A flag, when set true, indicates that the traceflow packet is of L3 routing.
        /// </summary>
        [JsonProperty(PropertyName = "routed")]
        public bool? Routed { get; set; }
        /// <summary>
        /// This type takes effect only for IP packet.
        /// </summary>
        [JsonProperty(PropertyName = "transport_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketDataTransportTypeEnumType? TransportType { get; set; }
        /// <summary>
        /// Packet configuration
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketDataResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// If the requested frame_size is too small (given the payload and traceflow metadata requirement of 16 bytes), the
        /// traceflow request will fail with an appropriate message.  The frame will be zero padded to the requested size.
        /// </summary>
        [JsonProperty(PropertyName = "frame_size")]
        public long? FrameSize { get; set; }
    }
}
