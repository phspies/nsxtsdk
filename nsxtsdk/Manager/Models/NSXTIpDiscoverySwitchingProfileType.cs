using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpDiscoverySwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// Indicates whether ARP snooping is enabled
        /// </summary>
        [JsonProperty(PropertyName = "arp_snooping_enabled")]
        public bool? ArpSnoopingEnabled { get; set; }
        /// <summary>
        /// Indicates the number of arp snooped IP addresses to be remembered per LogicalPort. Decreasing this value, will retain
        /// the latest bindings from the existing list of address bindings. Increasing this value will retain existing bindings and
        /// also learn any new address bindings discovered on the port until the new limit is reached. This limit only applies to
        /// IPv4 addresses and is independent of the nd_bindings_limit used for IPv6 snooping.
        /// </summary>
        [JsonProperty(PropertyName = "arp_bindings_limit")]
        public int? ArpBindingsLimit { get; set; }
        /// <summary>
        /// This option is the IPv6 equivalent of DHCP snooping.
        /// </summary>
        [JsonProperty(PropertyName = "dhcpv6_snooping_enabled")]
        public bool? Dhcpv6SnoopingEnabled { get; set; }
        /// <summary>
        /// This option is the IPv6 equivalent of ARP snooping.
        /// </summary>
        [JsonProperty(PropertyName = "nd_snooping_enabled")]
        public bool? NdSnoopingEnabled { get; set; }
        /// <summary>
        /// This option is only supported on ESX where vm-tools is installed.
        /// </summary>
        [JsonProperty(PropertyName = "vm_tools_v6_enabled")]
        public bool? VmToolsV6Enabled { get; set; }
        /// <summary>
        /// Indicates whether DHCP snooping is enabled
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_snooping_enabled")]
        public bool? DhcpSnoopingEnabled { get; set; }
        /// <summary>
        /// This property controls the ARP and ND cache timeout period.It
        /// is recommended that this property be greater than the ARP/ND
        /// cache timeout on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "arp_nd_binding_timeout")]
        public int? ArpNdBindingTimeout { get; set; }
        /// <summary>
        /// This option is only supported on ESX where vm-tools is installed.
        /// </summary>
        [JsonProperty(PropertyName = "vm_tools_enabled")]
        public bool? VmToolsEnabled { get; set; }
        /// <summary>
        /// ARP snooping being inherently susceptible to ARP spoofing,
        /// uses a turst-on-fisrt-use (TOFU) paradigm where only the first IP address
        /// discovered via ARP snooping is trusted. The remaining are ignored.
        /// In order to allow for more flexibility, we allow the user to
        /// configure how many ARP snooped address bindings should be trusted
        /// for the lifetime of the logical port. This is controlled by the
        /// arp_bindings_limit property in the IP Discovery profile. We refer
        /// to this extension of TOFU as N-TOFU.
        /// However, if TOFU is disabled, then N ARP snooped IP addresses will
        /// be trusted until they are timed out, where N is configured by
        /// arp_bindings_limit.
        /// </summary>
        [JsonProperty(PropertyName = "trust_on_first_use_enabled")]
        public bool? TrustOnFirstUseEnabled { get; set; }
        /// <summary>
        /// Indicates the number of neighbor-discovery snooped IP addresses to be remembered per LogicalPort. Decreasing this value,
        /// will retain the latest bindings from the existing list of address bindings. Increasing this value will retain existing
        /// bindings and also learn any new address bindings discovered on the port until the new limit is reached. This limit only
        /// applies to IPv6 addresses and is independent of the arp_bindings_limit used for IPv4 snooping.
        /// </summary>
        [JsonProperty(PropertyName = "nd_bindings_limit")]
        public int? NdBindingsLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_ip_detection")]
        public NSXTDuplicateIPDetectionType DuplicateIpDetection { get; set; }
    }
}
