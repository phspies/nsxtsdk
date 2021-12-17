// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVpnSessionStatisticsNsxTType : NSXTIPSecVpnSessionStatisticsPerEPType
    {
        public NSXTIPSecVpnSessionStatisticsNsxTType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_traffic_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTIPSecVpnIkeTrafficStatisticsType IkeTrafficStatistics { get; set; }
        /// <summary>
        /// Display Name of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display Name of vpn session.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Gives aggregate traffic statistics across all ipsec tunnels and individual tunnel
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "policy_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Gives aggregate traffic statistics across all ipsec tunnels and individual tunnelstatistics.")]
        public IList<NSXTIpSecVpnPolicyTrafficStatisticsType> PolicyStatistics { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTIPSecVpnIkeSessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTIPSecVpnTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
