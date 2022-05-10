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
    /// Summarized view of all selected IPSec VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"Summarized view of all selected IPSec VPN sessions.")]
    public class NSXTIPSecVPNSessionSummaryType 
    {
        /// <summary>
        /// Traffic summary per session.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_summary_per_session")]
        public IList<NSXTIPSecVPNSessionTrafficSummaryType> TrafficSummaryPerSession { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "session_summary")]
        public NSXTIPsecVPNIKESessionSummaryType SessionSummary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_traffic_counters")]
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
