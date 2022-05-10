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
    public class NSXTIpAddressPoolStaticSubnetType : NSXTIpAddressPoolSubnetType
    {
        /// <summary>
        /// The collection of upto 3 DNS servers for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "dns_nameservers")]
        public IList<string> DnsNameservers { get; set; }
        /// <summary>
        /// Subnet representation is a network address and prefix length
        /// </summary>
        [JsonProperty(PropertyName = "cidr", Required = Required.AllowNull)]
        public string Cidr { get; set; }
        /// <summary>
        /// The default gateway address on a layer-3 router.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        public string? GatewayIp { get; set; }
        /// <summary>
        /// A collection of IPv4 or IPv6 IP Pool Ranges.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_ranges", Required = Required.AllowNull)]
        public IList<NSXTIpPoolRangeType> AllocationRanges { get; set; }
        /// <summary>
        /// The DNS suffix for the DNS server.
        /// </summary>
        [JsonProperty(PropertyName = "dns_suffix")]
        public string? DnsSuffix { get; set; }
    }
}
