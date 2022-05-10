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
    public class NSXTL2VPNSessionStatisticsNsxTType : NSXTL2VPNSessionStatisticsPerEPType
    {
        /// <summary>
        /// Traffic statistics per segment.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_statistics_per_segment")]
        public IList<NSXTL2VPNTrafficStatisticsPerSegmentType> TrafficStatisticsPerSegment { get; set; }
        /// <summary>
        /// Display name of l2vpn session.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Tunnel port traffic counters.
        /// </summary>
        [JsonProperty(PropertyName = "tap_traffic_counters")]
        public IList<NSXTL2VPNTapStatisticsType> TapTrafficCounters { get; set; }
    }
}
