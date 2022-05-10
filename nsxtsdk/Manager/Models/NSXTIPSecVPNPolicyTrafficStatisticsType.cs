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
    /// IPSec VPN policy traffic statistics
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN policy traffic statistics")]
    public class NSXTIPSecVPNPolicyTrafficStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
        /// <summary>
        /// Tunnel statistics.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_statistics")]
        public IList<NSXTIPSecVPNTunnelTrafficStatisticsType> TunnelStatistics { get; set; }
        /// <summary>
        /// Tunnel port identifier.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_port_id")]
        public string? TunnelPortId { get; set; }
        /// <summary>
        /// Policy Identifier.
        /// </summary>
        [JsonProperty(PropertyName = "policy_id")]
        public string? PolicyId { get; set; }
    }
}
