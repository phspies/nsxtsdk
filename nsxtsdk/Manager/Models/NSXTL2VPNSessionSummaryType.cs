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
    /// List summary of L2VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"List summary of L2VPN sessions.")]
    public class NSXTL2VPNSessionSummaryType 
    {
        /// <summary>
        /// Total L2VPN sessions configured.
        /// </summary>
        [JsonProperty(PropertyName = "total_l2vpn_sessions")]
        public long? TotalL2vpnSessions { get; set; }
        /// <summary>
        /// Number of established L2VPN sessions. L2VPN session is established when all the tunnels are up.
        /// </summary>
        [JsonProperty(PropertyName = "established_l2vpn_sessions")]
        public long? EstablishedL2vpnSessions { get; set; }
        /// <summary>
        /// Number of failed L2VPN sessions. L2VPN session is failed when all the tunnels are down.
        /// </summary>
        [JsonProperty(PropertyName = "failed_l2vpn_sessions")]
        public long? FailedL2vpnSessions { get; set; }
    }
}
