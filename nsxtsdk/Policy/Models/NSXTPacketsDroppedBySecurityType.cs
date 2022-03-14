// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTPacketTypeAndCounterType> SpoofGuardDropped { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP server block".
        /// </summary>
        public long? DhcpServerDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP server block".
        /// </summary>
        public long? DhcpServerDroppedIpv6 { get; set; }
        /// <summary>
        /// The number of IPv4 packets dropped by "DHCP client block".
        /// </summary>
        public long? DhcpClientDroppedIpv4 { get; set; }
        /// <summary>
        /// The number of packets dropped by "BPDU filter".
        /// </summary>
        public long? BpduFilterDropped { get; set; }
        /// <summary>
        /// The number of IPv6 packets dropped by "DHCP client block".
        /// </summary>
        public long? DhcpClientDroppedIpv6 { get; set; }
    }
}
