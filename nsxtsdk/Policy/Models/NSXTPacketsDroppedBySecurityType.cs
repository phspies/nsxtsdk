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
    public class NSXTPacketsDroppedBySecurityType 
    {
        /// <summary>
        /// The packets dropped by "Spoof Guard"; supported packet types are IPv4, IPv6, ARP, ND, non-IP.
        /// </summary>
        [JsonProperty(PropertyName = "spoof_guard_dropped")]
        public IList<NSXTPacketTypeAndCounterType> SpoofGuardDropped { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP server block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_dropped_ipv4")]
        public long? DhcpServerDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP server block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_dropped_ipv6")]
        public long? DhcpServerDroppedIpv6 { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP client block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_dropped_ipv4")]
        public long? DhcpClientDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of packets dropped by "BPDU filter".
        /// </summary>
        [JsonProperty(PropertyName = "bpdu_filter_dropped")]
        public long? BpduFilterDropped { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP client block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_dropped_ipv6")]
        public long? DhcpClientDroppedIpv6 { get; set; }
    }
}
