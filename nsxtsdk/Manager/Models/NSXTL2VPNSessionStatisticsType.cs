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
    /// Session statistics gives VPN session status and traffic statistics per logical switch.
    /// </summary>
    [NSXTProperty(Description: @"Session statistics gives VPN session status and traffic statistics per logical switch.")]
    public class NSXTL2VPNSessionStatisticsType 
    {
        /// <summary>
        /// Traffic statistics per logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_statistics_per_logical_switch")]
        public IList<NSXTL2VPNPerLSTrafficStatisticsType> TrafficStatisticsPerLogicalSwitch { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Partial statistics is set to true if onle active node responds while standby does not. In case of both nodes responded
        /// statistics will be summed and partial stats will be false. If cluster has only active node, partial statistics will
        /// always be false.
        /// </summary>
        [JsonProperty(PropertyName = "partial_stats")]
        public bool? PartialStats { get; set; }
        /// <summary>
        /// Session identifier for L2VPN.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public string? SessionId { get; set; }
        /// <summary>
        /// Tunnel port traffic counters.
        /// </summary>
        [JsonProperty(PropertyName = "tap_traffic_counters")]
        public IList<NSXTL2VPNTapTrafficStatisticsType> TapTrafficCounters { get; set; }
    }
}
