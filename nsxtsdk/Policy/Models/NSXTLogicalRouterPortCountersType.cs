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
    public class NSXTLogicalRouterPortCountersType 
    {
        /// <summary>
        /// Number of no ARP packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "no_arp_dropped_packets")]
        public long? NoArpDroppedPackets { get; set; }
        /// <summary>
        /// The total number of packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets")]
        public long? DroppedPackets { get; set; }
        /// <summary>
        /// Number of packets dropped due to insufficient memory.
        /// </summary>
        [JsonProperty(PropertyName = "no_mem_dropped_packets")]
        public long? NoMemDroppedPackets { get; set; }
        /// <summary>
        /// Number of IPSec policy error packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_pol_err_dropped_packets")]
        public long? IpsecPolErrDroppedPackets { get; set; }
        /// <summary>
        /// Number of packets dropped as no linked ports are present.
        /// </summary>
        [JsonProperty(PropertyName = "no_linked_dropped_packets")]
        public long? NoLinkedDroppedPackets { get; set; }
        /// <summary>
        /// Number of DPDK kernal NIC interface packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "kni_dropped_packets")]
        public long? KniDroppedPackets { get; set; }
        /// <summary>
        /// The total number of packets blocked.
        /// </summary>
        [JsonProperty(PropertyName = "blocked_packets")]
        public long? BlockedPackets { get; set; }
        /// <summary>
        /// Number of reverse-path forwarding check packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "rpf_check_dropped_packets")]
        public long? RpfCheckDroppedPackets { get; set; }
        /// <summary>
        /// Number of IPSec policy block packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_pol_block_dropped_packets")]
        public long? IpsecPolBlockDroppedPackets { get; set; }
        /// <summary>
        /// Number of duplicate address detected packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "dad_dropped_packets")]
        public long? DadDroppedPackets { get; set; }
        /// <summary>
        /// Number of packets dropped due to absence of receiver.
        /// </summary>
        [JsonProperty(PropertyName = "no_receiver_dropped_packets")]
        public long? NoReceiverDroppedPackets { get; set; }
        /// <summary>
        /// Number of packets dropped due to unsupported L4 port.
        /// </summary>
        [JsonProperty(PropertyName = "l4port_unsupported_dropped_packets")]
        public long? L4portUnsupportedDroppedPackets { get; set; }
        /// <summary>
        /// Number of fragmentation needed packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "frag_needed_dropped_packets")]
        public long? FragNeededDroppedPackets { get; set; }
        /// <summary>
        /// Number of packtes dropped as destination is not supported.
        /// </summary>
        [JsonProperty(PropertyName = "destination_unsupported_dropped_packets")]
        public long? DestinationUnsupportedDroppedPackets { get; set; }
        /// <summary>
        /// Number of firewall packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "firewall_dropped_packets")]
        public long? FirewallDroppedPackets { get; set; }
        /// <summary>
        /// The number of no route packets dropped
        /// </summary>
        [JsonProperty(PropertyName = "no_route_dropped_packets")]
        public long? NoRouteDroppedPackets { get; set; }
        /// <summary>
        /// Number of packtes dropped as they are malformed.
        /// </summary>
        [JsonProperty(PropertyName = "malformed_dropped_packets")]
        public long? MalformedDroppedPackets { get; set; }
        /// <summary>
        /// Number of non IP packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "non_ip_dropped_packets")]
        public long? NonIpDroppedPackets { get; set; }
        /// <summary>
        /// Number of IPSec packets dropped
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_dropped_packets")]
        public long? IpsecDroppedPackets { get; set; }
        /// <summary>
        /// Number of redirect packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_dropped_packets")]
        public long? RedirectDroppedPackets { get; set; }
        /// <summary>
        /// Number of service insert packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "service_insert_dropped_packets")]
        public long? ServiceInsertDroppedPackets { get; set; }
        /// <summary>
        /// Number of IPSec packets dropped as no VTI is present.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_no_vti_dropped_packets")]
        public long? IpsecNoVtiDroppedPackets { get; set; }
        /// <summary>
        /// The total number of packets transferred.
        /// </summary>
        [JsonProperty(PropertyName = "total_packets")]
        public long? TotalPackets { get; set; }
        /// <summary>
        /// Number of packets dropped as protocol is unsupported.
        /// </summary>
        [JsonProperty(PropertyName = "proto_unsupported_dropped_packets")]
        public long? ProtoUnsupportedDroppedPackets { get; set; }
        /// <summary>
        /// Number of time to live exceeded packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "ttl_exceeded_dropped_packets")]
        public long? TtlExceededDroppedPackets { get; set; }
        /// <summary>
        /// Number of IPV6 packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_dropped_packets")]
        public long? Ipv6DroppedPackets { get; set; }
        /// <summary>
        /// Number of IPSec no security association packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_no_sa_dropped_packets")]
        public long? IpsecNoSaDroppedPackets { get; set; }
        /// <summary>
        /// The total number of bytes transferred.
        /// </summary>
        [JsonProperty(PropertyName = "total_bytes")]
        public long? TotalBytes { get; set; }
    }
}
