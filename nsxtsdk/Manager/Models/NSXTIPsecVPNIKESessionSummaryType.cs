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
    /// IPSec VPN session status summary, gives total, failed, degraded and established IPSec VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN session status summary, gives total, failed, degraded and established IPSec VPN sessions.")]
    public class NSXTIPsecVPNIKESessionSummaryType 
    {
        /// <summary>
        /// Number of established sessions.
        /// </summary>
        [JsonProperty(PropertyName = "established_sessions")]
        public long? EstablishedSessions { get; set; }
        /// <summary>
        /// Total sessions configured.
        /// </summary>
        [JsonProperty(PropertyName = "total_sessions")]
        public long? TotalSessions { get; set; }
        /// <summary>
        /// Number of failed sessions.
        /// </summary>
        [JsonProperty(PropertyName = "failed_sessions")]
        public long? FailedSessions { get; set; }
        /// <summary>
        /// Number of degraded sessions.
        /// </summary>
        [JsonProperty(PropertyName = "degraded_sessions")]
        public long? DegradedSessions { get; set; }
    }
}
