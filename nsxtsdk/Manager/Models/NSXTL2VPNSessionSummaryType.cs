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
    /// List summary of L2VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"List summary of L2VPN sessions.")]
    public class NSXTL2VPNSessionSummaryType 
    {
        /// <summary>
        /// Total L2VPN sessions configured.
        /// </summary>
        [JsonProperty(PropertyName = "total_l2vpn_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Total L2VPN sessions configured.")]
        public long? TotalL2vpnSessions { get; set; }
        /// <summary>
        /// Number of established L2VPN sessions. L2VPN session is established when all the tunnels are up.
        /// </summary>
        [JsonProperty(PropertyName = "established_l2vpn_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Number of established L2VPN sessions. L2VPN session is established when all the tunnels are up.")]
        public long? EstablishedL2vpnSessions { get; set; }
        /// <summary>
        /// Number of failed L2VPN sessions. L2VPN session is failed when all the tunnels are down.
        /// </summary>
        [JsonProperty(PropertyName = "failed_l2vpn_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Number of failed L2VPN sessions. L2VPN session is failed when all the tunnels are down.")]
        public long? FailedL2vpnSessions { get; set; }
    }
}