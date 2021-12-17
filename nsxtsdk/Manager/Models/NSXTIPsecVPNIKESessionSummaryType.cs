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
    /// IPSec VPN session status summary, gives total, failed, degraded and established IPSec VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN session status summary, gives total, failed, degraded and established IPSec VPN sessions.")]
    public class NSXTIPsecVPNIKESessionSummaryType 
    {
        public NSXTIPsecVPNIKESessionSummaryType()
        {
        }
        /// <summary>
        /// Number of established sessions.
        /// </summary>
        [JsonProperty(PropertyName = "established_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Number of established sessions.")]
        public long? EstablishedSessions { get; set; }
        /// <summary>
        /// Total sessions configured.
        /// </summary>
        [JsonProperty(PropertyName = "total_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Total sessions configured.")]
        public long? TotalSessions { get; set; }
        /// <summary>
        /// Number of failed sessions.
        /// </summary>
        [JsonProperty(PropertyName = "failed_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Number of failed sessions.")]
        public long? FailedSessions { get; set; }
        /// <summary>
        /// Number of degraded sessions.
        /// </summary>
        [JsonProperty(PropertyName = "degraded_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Number of degraded sessions.")]
        public long? DegradedSessions { get; set; }
    }
}
