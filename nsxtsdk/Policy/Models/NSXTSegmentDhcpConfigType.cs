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
    /// DHCP IPv4 and IPv6 configurations are extended from this abstract class.
    /// </summary>
    [NSXTProperty(Description: @"DHCP IPv4 and IPv6 configurations are extended from this abstract class.")]
    public class NSXTSegmentDhcpConfigType 
    {
        /// <summary>
        /// IP address of the DHCP server in CIDR format.
        /// The server_address is mandatory in case this segment has provided a
        /// dhcp_config_path and it represents a DHCP server config.
        /// If this SegmentDhcpConfig is a SegmentDhcpV4Config, the address must
        /// be an IPv4 address. If this is a SegmentDhcpV6Config, the address must
        /// be an IPv6 address.
        /// This address must not overlap the ip-ranges of the subnet, or the
        /// gateway address of the subnet, or the DHCP static-binding addresses
        /// of this segment.
        /// </summary>
        [JsonProperty(PropertyName = "server_address")]
        public string? ServerAddress { get; set; }
        /// <summary>
        /// IP address of DNS servers for subnet. DNS server IP address must
        /// belong to the same address family as segment gateway_address
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// DHCP lease time in seconds. When specified, this property overwrites
        /// lease time configured DHCP server config.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentDhcpConfigResourceTypeEnumType ResourceType { get; set; }
    }
}
