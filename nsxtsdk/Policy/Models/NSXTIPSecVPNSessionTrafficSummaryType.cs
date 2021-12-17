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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// IPSec VPN session traffic summary.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN session traffic summary.")]
    public class NSXTIPSecVPNSessionTrafficSummaryType 
    {
        public NSXTIPSecVPNSessionTrafficSummaryType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "traffic_counters")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTIPSecVPNTrafficCountersType TrafficCounters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_session")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType IpsecVpnSession { get; set; }
    }
}
