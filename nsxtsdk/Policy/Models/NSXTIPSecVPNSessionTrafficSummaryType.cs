using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using nsxtsdk.ManagerModels;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// IPSec VPN session traffic summary.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN session traffic summary.")]
    public class NSXTIPSecVPNSessionTrafficSummaryType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "traffic_counters")]
        public NSXTIPSecVPNTrafficCountersType TrafficCounters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_session")]
        public NSXTResourceReferenceType IpsecVpnSession { get; set; }
    }
}
