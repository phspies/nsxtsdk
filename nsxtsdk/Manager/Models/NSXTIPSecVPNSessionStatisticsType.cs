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
    /// Session statistics gives aggregated statistics of all policies for all the tunnels.
    /// </summary>
    [NSXTProperty(Description: @"Session statistics gives aggregated statistics of all policies for all the tunnels.")]
    public class NSXTIPSecVPNSessionStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_traffic_statistics")]
        public NSXTIPSecVPNIKETrafficStatisticsType IkeTrafficStatistics { get; set; }
        /// <summary>
        /// Display name of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Gives aggregate traffic statistics across all ipsec tunnels and individual tunnel statistics.
        /// </summary>
        [JsonProperty(PropertyName = "policy_statistics")]
        public IList<NSXTIPSecVPNPolicyTrafficStatisticsType> PolicyStatistics { get; set; }
        /// <summary>
        /// Partial statistics if true specifies that the statistics are only from active node.
        /// </summary>
        [JsonProperty(PropertyName = "partial_stats")]
        public bool? PartialStats { get; set; }
        /// <summary>
        /// UUID of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_session_id")]
        public string? IpsecVpnSessionId { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_status")]
        public NSXTIPSecVPNIKESessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
