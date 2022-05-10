using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using nsxtsdk.ManagerModels;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// IPSec VPN policy traffic statistics.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN policy traffic statistics.")]
    public class NSXTIPSecVpnPolicyTrafficStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVpnTrafficCountersType AggregateTrafficCounters { get; set; }
        /// <summary>
        /// Tunnel statistics.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_statistics")]
        public IList<NSXTIPSecVPNTunnelTrafficStatisticsType> TunnelStatistics { get; set; }
        /// <summary>
        /// L3Vpn rule path.
        /// </summary>
        [JsonProperty(PropertyName = "rule_path")]
        public string? RulePath { get; set; }
    }
}
