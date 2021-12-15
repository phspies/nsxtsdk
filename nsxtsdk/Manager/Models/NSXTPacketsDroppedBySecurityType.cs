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

namespace nsxtsdk.ManagerModels
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
        [NSXTProperty(IsRequired: false, Description: @"The packets dropped by &quot;Spoof Guard&quot;; supported packet types are IPv4, IPv6, ARP, ND, non-IP.")]
        public IList<NSXTPacketTypeAndCounterType> SpoofGuardDropped { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP server block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_dropped_ipv4")]
        [NSXTProperty(IsRequired: false, Description: @"The number of IPv4 packets dropped by &quot;DHCP server block&quot;.")]
        public long? DhcpServerDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP server block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_dropped_ipv6")]
        [NSXTProperty(IsRequired: false, Description: @"The number of IPv6 packets dropped by &quot;DHCP server block&quot;.")]
        public long? DhcpServerDroppedIpv6 { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP client block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_dropped_ipv4")]
        [NSXTProperty(IsRequired: false, Description: @"The number of IPv4 packets dropped by &quot;DHCP client block&quot;.")]
        public long? DhcpClientDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of packets dropped by "BPDU filter".
        /// </summary>
        [JsonProperty(PropertyName = "bpdu_filter_dropped")]
        [NSXTProperty(IsRequired: false, Description: @"The number of packets dropped by &quot;BPDU filter&quot;.")]
        public long? BpduFilterDropped { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP client block".
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_dropped_ipv6")]
        [NSXTProperty(IsRequired: false, Description: @"The number of IPv6 packets dropped by &quot;DHCP client block&quot;.")]
        public long? DhcpClientDroppedIpv6 { get; set; }
    }
}