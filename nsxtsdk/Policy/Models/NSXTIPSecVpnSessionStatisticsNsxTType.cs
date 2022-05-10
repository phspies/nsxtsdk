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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVpnSessionStatisticsNsxTType : NSXTIPSecVpnSessionStatisticsPerEPType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_traffic_statistics")]
        public NSXTIPSecVpnIkeTrafficStatisticsType IkeTrafficStatistics { get; set; }
        /// <summary>
        /// Display Name of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Gives aggregate traffic statistics across all ipsec tunnels and individual tunnel
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "policy_statistics")]
        public IList<NSXTIPSecVPNPolicyTrafficStatisticsType> PolicyStatistics { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_status")]
        public NSXTIPSecVpnIkeSessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVpnTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
