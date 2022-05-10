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
    public class NSXTTransportProtocolHeaderType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "udp_header")]
        public NSXTUdpHeaderType UdpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_header")]
        public NSXTDhcpHeaderType DhcpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_header")]
        public NSXTTcpHeaderType TcpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "icmp_echo_request_header")]
        public NSXTIcmpEchoRequestHeaderType IcmpEchoRequestHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dhcpv6_header")]
        public NSXTDhcpv6HeaderType Dhcpv6Header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ndp_header")]
        public NSXTNdpHeaderType NdpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_header")]
        public NSXTDnsHeaderType DnsHeader { get; set; }
    }
}
