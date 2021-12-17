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
    public class NSXTIPSecVpnSessionStatusNsxTType : NSXTIPSecVpnSessionStatusPerEPType
    {
        public NSXTIPSecVpnSessionStatusNsxTType()
        {
        }
        /// <summary>
        /// Gives session status consolidated using IKE status and tunnel status. It can
        /// be UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, if
        /// all down it will be DOWN, otherwise it will be DEGRADED.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [NSXTProperty(IsRequired: false, Description: @"Gives session status consolidated using IKE status and tunnel status. It canbe UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, ifall down it will be DOWN, otherwise it will be DEGRADED.")]
        public NSXTIpsecVpnSessionStatusNsxTRuntimeStatusEnumType? RuntimeStatus { get; set; }
        /// <summary>
        /// Display Name of vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display Name of vpn session.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Number of failed tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "failed_tunnels")]
        [NSXTProperty(IsRequired: false, Description: @"Number of failed tunnels.")]
        public long? FailedTunnels { get; set; }
        /// <summary>
        /// Number of negotiated tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "negotiated_tunnels")]
        [NSXTProperty(IsRequired: false, Description: @"Number of negotiated tunnels.")]
        public long? NegotiatedTunnels { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Total number of tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "total_tunnels")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of tunnels.")]
        public long? TotalTunnels { get; set; }
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
