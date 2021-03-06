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
    /// Advanced load balancer NetworkProfileUnion object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkProfileUnion object")]
    public class NSXTALBNetworkProfileUnionType 
    {
        /// <summary>
        /// Configure one of either proxy or fast path profiles.
        /// Enum options - PROTOCOL_TYPE_TCP_PROXY,
        /// PROTOCOL_TYPE_TCP_FAST_PATH, PROTOCOL_TYPE_UDP_FAST_PATH,
        /// PROTOCOL_TYPE_UDP_PROXY.
        /// Allowed in Basic(Allowed values-
        /// PROTOCOL_TYPE_TCP_PROXY,PROTOCOL_TYPE_TCP_FAST_PATH,PROTOCOL_TYPE_UDP_FAST_PATH)
        /// edition, Essentials(Allowed values-
        /// PROTOCOL_TYPE_TCP_FAST_PATH,PROTOCOL_TYPE_UDP_FAST_PATH)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as PROTOCOL_TYPE_TCP_PROXY.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbnetworkProfileUnionTypeEnumType Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_proxy_profile")]
        public NSXTALBTCPProxyProfileType TcpProxyProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_fast_path_profile")]
        public NSXTALBTCPFastPathProfileType TcpFastPathProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "udp_proxy_profile")]
        public NSXTALBUDPProxyProfileType UdpProxyProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "udp_fast_path_profile")]
        public NSXTALBUDPFastPathProfileType UdpFastPathProfile { get; set; }
    }
}
