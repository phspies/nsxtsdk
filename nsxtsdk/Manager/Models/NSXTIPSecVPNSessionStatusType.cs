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
    /// IKE session traffic summary provides IKE session status and aggregate of traffic across all tunnel.
    /// </summary>
    [NSXTProperty(Description: @"IKE session traffic summary provides IKE session status and aggregate of traffic across all tunnel.")]
    public class NSXTIPSecVPNSessionStatusType 
    {
        /// <summary>
        /// UUID of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_session_id")]
        public string? IpsecVpnSessionId { get; set; }
        /// <summary>
        /// Display name of vpn session.
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
        /// Gives session status consolidated using IKE status and tunnel status. It can be UP, DOWN, DEGRADED. If IKE and all
        /// tunnels are UP status will be UP, if all down it will be DOWN, otherwise it will be DEGRADED.
        /// </summary>
        [JsonProperty(PropertyName = "session_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnsessionStatusSessionStatusEnumType? SessionStatus { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ike_status")]
        public NSXTIPSecVPNIKESessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// Total number of tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "total_tunnels")]
        public long? TotalTunnels { get; set; }
    }
}
