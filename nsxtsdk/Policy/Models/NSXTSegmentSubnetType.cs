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
    /// Subnet configuration for segment
    /// </summary>
    [NSXTProperty(Description: @"Subnet configuration for segment")]
    public class NSXTSegmentSubnetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_config")]
        public NSXTSegmentDhcpConfigType DhcpConfig { get; set; }
        /// <summary>
        /// Gateway IP address in CIDR format for both IPv4 and IPv6.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_address")]
        public string? GatewayAddress { get; set; }
        /// <summary>
        /// DHCP address ranges are used for dynamic IP allocation.
        /// Supports address range and CIDR formats. First valid
        /// host address from the first value is assigned to DHCP server
        /// IP address. Existing values cannot be deleted or modified,
        /// but additional DHCP ranges can be added.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_ranges")]
        public IList<string> DhcpRanges { get; set; }
        /// <summary>
        /// Network CIDR for this subnet calculated from gateway_addresses and
        /// prefix_len.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
    }
}
