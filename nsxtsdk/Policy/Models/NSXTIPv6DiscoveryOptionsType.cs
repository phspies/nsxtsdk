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
    /// Contains IPv6 related discovery options.
    /// </summary>
    [NSXTProperty(Description: @"Contains IPv6 related discovery options.")]
    public class NSXTIPv6DiscoveryOptionsType 
    {
        /// <summary>
        /// Indicates ND snooping options
        /// </summary>
        [JsonProperty(PropertyName = "nd_snooping_config")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates ND snooping options")]
        public NSXTNdSnoopingConfigType NdSnoopingConfig { get; set; }
        /// <summary>
        /// Enable this method will snoop the DHCPv6 message transaction
        /// which a VM makes with a DHCPv6 server. From the transaction, we
        /// learn the IPv6 addresses assigned by the DHCPv6 server to this VM
        /// along with its lease time.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_snooping_v6_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable this method will snoop the DHCPv6 message transactionwhich a VM makes with a DHCPv6 server. From the transaction, welearn the IPv6 addresses assigned by the DHCPv6 server to this VMalong with its lease time.")]
        public bool? DhcpSnoopingV6Enabled { get; set; }
        /// <summary>
        /// Enable this method will learn the IPv6 addresses which are
        /// configured on interfaces of a VM with the help of the VMTools software.
        /// </summary>
        [JsonProperty(PropertyName = "vmtools_v6_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable this method will learn the IPv6 addresses which areconfigured on interfaces of a VM with the help of the VMTools software.")]
        public bool? VmtoolsV6Enabled { get; set; }
    }
}
