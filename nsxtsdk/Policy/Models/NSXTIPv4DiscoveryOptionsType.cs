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
    /// Contains IPv4 related discovery options.
    /// </summary>
    [NSXTProperty(Description: @"Contains IPv4 related discovery options.")]
    public class NSXTIPv4DiscoveryOptionsType 
    {
        /// <summary>
        /// Indicates whether fetching IP using vm-tools is enabled.
        /// This option is only supported on ESX where vm-tools is installed.
        /// </summary>
        [JsonProperty(PropertyName = "vmtools_enabled")]
        public bool? VmtoolsEnabled { get; set; }
        /// <summary>
        /// Indicates whether DHCP snooping is enabled
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_snooping_enabled")]
        public bool? DhcpSnoopingEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "arp_snooping_config")]
        public NSXTArpSnoopingConfigType ArpSnoopingConfig { get; set; }
    }
}
