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
    public class NSXTL2VpnSessionStatisticsType : NSXTL2VpnStatisticsPerEnforcementPointType
    {
        /// <summary>
        /// Traffic statistics per segment.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_statistics_per_segment")]
        public IList<NSXTL2VpnPerSegmentTrafficStatisticsType> TrafficStatisticsPerSegment { get; set; }
        /// <summary>
        /// Tunnel port traffic counters.
        /// </summary>
        [JsonProperty(PropertyName = "tap_traffic_counters")]
        public IList<NSXTL2VpnTapTrafficStatisticsType> TapTrafficCounters { get; set; }
    }
}
