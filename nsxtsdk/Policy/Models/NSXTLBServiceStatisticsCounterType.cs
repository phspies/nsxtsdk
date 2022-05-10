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
    public class NSXTLBServiceStatisticsCounterType 
    {
        /// <summary>
        /// Number of l4 total sessions.
        /// </summary>
        [JsonProperty(PropertyName = "l4_total_sessions")]
        public long? L4TotalSessions { get; set; }
        /// <summary>
        /// Number of l7 current sessions.
        /// </summary>
        [JsonProperty(PropertyName = "l7_current_sessions")]
        public long? L7CurrentSessions { get; set; }
        /// <summary>
        /// L4 max sessions is used to show the peak L4 max session data since
        /// load balancer starts to provide service.
        /// </summary>
        [JsonProperty(PropertyName = "l4_max_sessions")]
        public long? L4MaxSessions { get; set; }
        /// <summary>
        /// Number of l4 current sessions.
        /// </summary>
        [JsonProperty(PropertyName = "l4_current_sessions")]
        public long? L4CurrentSessions { get; set; }
        /// <summary>
        /// Number of l7 total sessions.
        /// </summary>
        [JsonProperty(PropertyName = "l7_total_sessions")]
        public long? L7TotalSessions { get; set; }
        /// <summary>
        /// The average number of l4 current sessions per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "l4_current_session_rate")]
        public double? L4CurrentSessionRate { get; set; }
        /// <summary>
        /// The average number of l7 current requests per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "l7_current_session_rate")]
        public double? L7CurrentSessionRate { get; set; }
        /// <summary>
        /// L7 max sessions is used to show the peak L7 max session data since
        /// load balancer starts to provide service.
        /// </summary>
        [JsonProperty(PropertyName = "l7_max_sessions")]
        public long? L7MaxSessions { get; set; }
    }
}
