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
    public class NSXTIPSecVpnSessionStatusNsxTType : NSXTIPSecVpnSessionStatusPerEPType
    {
        /// <summary>
        /// Gives session status consolidated using IKE status and tunnel status. It can
        /// be UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, if
        /// all down it will be DOWN, otherwise it will be DEGRADED.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionStatusNsxTRuntimeStatusEnumType? RuntimeStatus { get; set; }
        /// <summary>
        /// Display Name of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Number of failed tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "failed_tunnels")]
        public long? FailedTunnels { get; set; }
        /// <summary>
        /// Number of negotiated tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "negotiated_tunnels")]
        public long? NegotiatedTunnels { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Total number of tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "total_tunnels")]
        public long? TotalTunnels { get; set; }
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
