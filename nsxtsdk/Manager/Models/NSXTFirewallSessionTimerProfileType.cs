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
    public class NSXTFirewallSessionTimerProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// The timeout value of connection in seconds after one endpoint sends an RST. The default value for Edges (i.e, Gateway,
        /// or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_closed", Required = Required.AllowNull)]
        public long TcpClosed { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after a second packet has been transferred. The default value for Edges (i.e,
        /// Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_opening", Required = Required.AllowNull)]
        public long TcpOpening { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds if the source host sends more than one packet but the destination host has
        /// never sent one back. The default value for Edges (i.e, Gateway, or Logical Router) may be different than Distributed
        /// Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "udp_single", Required = Required.AllowNull)]
        public long UdpSingle { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after both FINs have been exchanged and connection is closed. The default
        /// value for Edges (i.e, Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_finwait", Required = Required.AllowNull)]
        public long TcpFinwait { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after the first packet has been sent. The default value for Edges (i.e,
        /// Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_first_packet", Required = Required.AllowNull)]
        public long TcpFirstPacket { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after the first FIN has been sent. The default value for Edges (i.e, Gateway,
        /// or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_closing", Required = Required.AllowNull)]
        public long TcpClosing { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds once the connection has become fully established. The default value for Edges
        /// (i.e, Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_established", Required = Required.AllowNull)]
        public long TcpEstablished { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds if both hosts have sent packets. The default value for Edges (i.e, Gateway,
        /// or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "udp_multiple", Required = Required.AllowNull)]
        public long UdpMultiple { get; set; }
        /// <summary>
        /// The timeout value for the connection after an ICMP error came back in response to an ICMP packet. The default value for
        /// Edges (i.e, Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_error_reply", Required = Required.AllowNull)]
        public long IcmpErrorReply { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after the first packet. This will be the initial timeout for the new UDP
        /// flow. The default value for Edges (i.e, Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "udp_first_packet", Required = Required.AllowNull)]
        public long UdpFirstPacket { get; set; }
        /// <summary>
        /// The timeout value of connection in seconds after the first packet. This will be the initial timeout for the new ICMP
        /// flow. The default value for Edges (i.e, Gateway, or Logical Router) may be different than Distributed Firewall hosts.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_first_packet", Required = Required.AllowNull)]
        public long IcmpFirstPacket { get; set; }
    }
}
