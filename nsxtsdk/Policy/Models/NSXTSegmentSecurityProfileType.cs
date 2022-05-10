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
    public class NSXTSegmentSecurityProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Indicates whether BPDU filter is enabled. BPDU filtering is enabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "bpdu_filter_enable")]
        public bool? BpduFilterEnable { get; set; }
        /// <summary>
        /// Enable or disable Router Advertisement Guard.
        /// </summary>
        [JsonProperty(PropertyName = "ra_guard_enabled")]
        public bool? RaGuardEnabled { get; set; }
        /// <summary>
        /// Filters DHCP server and/or client IPv6 traffic. DHCP server
        /// blocking is enabled and client blocking is disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_block_v6_enabled")]
        public bool? DhcpClientBlockV6Enabled { get; set; }
        /// <summary>
        /// A flag to block all traffic except IP/(G)ARP/BPDU.
        /// </summary>
        [JsonProperty(PropertyName = "non_ip_traffic_block_enabled")]
        public bool? NonIpTrafficBlockEnabled { get; set; }
        /// <summary>
        /// Pre-defined list of allowed MAC addresses to be excluded from BPDU filtering.
        /// List of allowed MACs - 01:80:c2:00:00:00, 01:80:c2:00:00:01, 01:80:c2:00:00:02, 01:80:c2:00:00:03,
        /// 01:80:c2:00:00:04, 01:80:c2:00:00:05, 01:80:c2:00:00:06, 01:80:c2:00:00:07,
        /// 01:80:c2:00:00:08, 01:80:c2:00:00:09, 01:80:c2:00:00:0a, 01:80:c2:00:00:0b,
        /// 01:80:c2:00:00:0c, 01:80:c2:00:00:0d, 01:80:c2:00:00:0e, 01:80:c2:00:00:0f,
        /// 00:e0:2b:00:00:00, 00:e0:2b:00:00:04, 00:e0:2b:00:00:06, 01:00:0c:00:00:00,
        /// 01:00:0c:cc:cc:cc, 01:00:0c:cc:cc:cd, 01:00:0c:cd:cd:cd, 01:00:0c:cc:cc:c0,
        /// 01:00:0c:cc:cc:c1, 01:00:0c:cc:cc:c2, 01:00:0c:cc:cc:c3, 01:00:0c:cc:cc:c4,
        /// 01:00:0c:cc:cc:c5, 01:00:0c:cc:cc:c6, 01:00:0c:cc:cc:c7
        /// </summary>
        [JsonProperty(PropertyName = "bpdu_filter_allow")]
        public IList<string> BpduFilterAllow { get; set; }
        /// <summary>
        /// Filters DHCP server and/or client traffic. DHCP server
        /// blocking is enabled and client blocking is disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_block_enabled")]
        public bool? DhcpServerBlockEnabled { get; set; }
        /// <summary>
        /// Enable or disable Rate Limits
        /// </summary>
        [JsonProperty(PropertyName = "rate_limits_enabled")]
        public bool? RateLimitsEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_limits")]
        public NSXTTrafficRateLimitsType RateLimits { get; set; }
        /// <summary>
        /// Filters DHCP server and/or client traffic. DHCP server
        /// blocking is enabled and client blocking is disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_client_block_enabled")]
        public bool? DhcpClientBlockEnabled { get; set; }
        /// <summary>
        /// Filters DHCP server and/or client IPv6 traffic. DHCP server
        /// blocking is enabled and client blocking is disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_block_v6_enabled")]
        public bool? DhcpServerBlockV6Enabled { get; set; }
    }
}
