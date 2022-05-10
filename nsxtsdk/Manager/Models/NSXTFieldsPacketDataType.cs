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
    public class NSXTFieldsPacketDataType : NSXTPacketDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_header")]
        public NSXTIpv6HeaderType Ipv6Header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "arp_header")]
        public NSXTArpHeaderType ArpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_header")]
        public NSXTTransportProtocolHeaderType TransportHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_header")]
        public NSXTIpv4HeaderType IpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "eth_header")]
        public NSXTEthernetHeaderType EthHeader { get; set; }
        /// <summary>
        /// Up to 1000 bytes of payload may be supplied (with a base64-encoded length of 1336 bytes.) Additional bytes of traceflow
        /// metadata will be appended to the payload. The payload contains any data the user wants to put after the transport
        /// header.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public string? Payload { get; set; }
    }
}
