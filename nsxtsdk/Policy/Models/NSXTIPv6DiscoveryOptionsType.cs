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
    /// Contains IPv6 related discovery options.
    /// </summary>
    [NSXTProperty(Description: @"Contains IPv6 related discovery options.")]
    public class NSXTIPv6DiscoveryOptionsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "nd_snooping_config")]
        public NSXTNdSnoopingConfigType NdSnoopingConfig { get; set; }
        /// <summary>
        /// Enable this method will snoop the DHCPv6 message transaction
        /// which a VM makes with a DHCPv6 server. From the transaction, we
        /// learn the IPv6 addresses assigned by the DHCPv6 server to this VM
        /// along with its lease time.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_snooping_v6_enabled")]
        public bool? DhcpSnoopingV6Enabled { get; set; }
        /// <summary>
        /// Enable this method will learn the IPv6 addresses which are
        /// configured on interfaces of a VM with the help of the VMTools software.
        /// </summary>
        [JsonProperty(PropertyName = "vmtools_v6_enabled")]
        public bool? VmtoolsV6Enabled { get; set; }
    }
}
