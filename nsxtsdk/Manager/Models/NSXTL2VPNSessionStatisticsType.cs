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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Session statistics gives VPN session status and traffic statistics per logical switch.
    /// </summary>
    [NSXTProperty(Description: @"Session statistics gives VPN session status and traffic statistics per logical switch.")]
    public class NSXTL2VPNSessionStatisticsType 
    {
        /// <summary>
        /// Traffic statistics per logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_statistics_per_logical_switch")]
        [NSXTProperty(IsRequired: false, Description: @"Traffic statistics per logical switch.")]
        public IList<NSXTL2VPNPerLSTrafficStatisticsType> TrafficStatisticsPerLogicalSwitch { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"L2VPN display name.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Partial statistics is set to true if onle active node responds while standby does not. In case of both nodes responded
        /// statistics will be summed and partial stats will be false. If cluster has only active node, partial statistics will
        /// always be false.
        /// </summary>
        [JsonProperty(PropertyName = "partial_stats")]
        [NSXTProperty(IsRequired: false, Description: @"Partial statistics is set to true if onle active node responds while standby does not. In case of both nodes responded statistics will be summed and partial stats will be false. If cluster has only active node, partial statistics will always be false.")]
        public bool? PartialStats { get; set; }
        /// <summary>
        /// Session identifier for L2VPN.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        [NSXTProperty(IsRequired: false, Description: @"Session identifier for L2VPN.")]
        public string? SessionId { get; set; }
        /// <summary>
        /// Tunnel port traffic counters.
        /// </summary>
        [JsonProperty(PropertyName = "tap_traffic_counters")]
        [NSXTProperty(IsRequired: false, Description: @"Tunnel port traffic counters.")]
        public IList<NSXTL2VPNTapTrafficStatisticsType> TapTrafficCounters { get; set; }
    }
}