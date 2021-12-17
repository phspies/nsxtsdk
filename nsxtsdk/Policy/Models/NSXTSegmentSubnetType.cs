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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Subnet configuration for segment
    /// </summary>
    [NSXTProperty(Description: @"Subnet configuration for segment")]
    public class NSXTSegmentSubnetType 
    {
        public NSXTSegmentSubnetType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_config")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSegmentDhcpConfigType DhcpConfig { get; set; }
        /// <summary>
        /// Gateway IP address in CIDR format for both IPv4 and IPv6.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_address")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway IP address in CIDR format for both IPv4 and IPv6.")]
        public string? GatewayAddress { get; set; }
        /// <summary>
        /// DHCP address ranges are used for dynamic IP allocation.
        /// Supports address range and CIDR formats. First valid
        /// host address from the first value is assigned to DHCP server
        /// IP address. Existing values cannot be deleted or modified,
        /// but additional DHCP ranges can be added.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_ranges")]
        [NSXTProperty(IsRequired: false, Description: @"DHCP address ranges are used for dynamic IP allocation.Supports address range and CIDR formats. First validhost address from the first value is assigned to DHCP serverIP address. Existing values cannot be deleted or modified,but additional DHCP ranges can be added.")]
        public IList<string> DhcpRanges { get; set; }
        /// <summary>
        /// Network CIDR for this subnet calculated from gateway_addresses and
        /// prefix_len.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        [NSXTProperty(IsRequired: false, Description: @"Network CIDR for this subnet calculated from gateway_addresses andprefix_len.")]
        public string? Network { get; set; }
    }
}
