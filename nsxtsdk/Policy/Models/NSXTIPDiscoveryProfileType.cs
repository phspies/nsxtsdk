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
    public class NSXTIPDiscoveryProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This property controls the ARP and ND cache timeout period. It
        /// is recommended that this property be greater than the ARP/ND
        /// cache timeout on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "arp_nd_binding_timeout")]
        public int? ArpNdBindingTimeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_v6_discovery_options")]
        public NSXTIPv6DiscoveryOptionsType IpV6DiscoveryOptions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_ip_detection")]
        public NSXTDuplicateIPDetectionOptionsType DuplicateIpDetection { get; set; }
        /// <summary>
        /// Indicates whether "Trust on First Use(TOFU)" paradigm is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "tofu_enabled")]
        public bool? TofuEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_v4_discovery_options")]
        public NSXTIPv4DiscoveryOptionsType IpV4DiscoveryOptions { get; set; }
    }
}
