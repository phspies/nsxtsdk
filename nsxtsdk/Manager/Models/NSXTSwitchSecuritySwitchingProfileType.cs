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
    public class NSXTSwitchSecuritySwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bpdu_filter")]
        public NSXTBpduFilterType BpduFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_limits")]
        public NSXTRateLimitsType RateLimits { get; set; }
        /// <summary>
        /// RA Guard when enabled blocks unauthorized/rogue Router Advertisement (RA) packets.
        /// </summary>
        [JsonProperty(PropertyName = "ra_guard_enabled")]
        public bool? RaGuardEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_filter")]
        public NSXTDhcpFilterType DhcpFilter { get; set; }
        /// <summary>
        /// A flag to block all traffic except IP/(G)ARP/BPDU
        /// </summary>
        [JsonProperty(PropertyName = "block_non_ip_traffic")]
        public bool? BlockNonIpTraffic { get; set; }
    }
}
