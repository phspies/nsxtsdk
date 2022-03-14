// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? EstablishedSessions { get; set; }
        /// <summary>
        /// Total sessions configured.
        /// </summary>
        public long? TotalSessions { get; set; }
        /// <summary>
        /// Number of failed sessions.
        /// </summary>
        public long? FailedSessions { get; set; }
        /// <summary>
        /// Number of degraded sessions.
        /// </summary>
        public long? DegradedSessions { get; set; }
    }
}
