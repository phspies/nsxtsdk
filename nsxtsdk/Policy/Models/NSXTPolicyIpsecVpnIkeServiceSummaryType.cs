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
    public class NSXTPolicyIpsecVpnIkeServiceSummaryType : NSXTPolicyIpsecVpnSessionSummaryType
    {
        /// <summary>
        /// Display name of IPSec VPN service
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Policy path of IPSec VPN service
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_service_path")]
        public string? IpsecVpnServicePath { get; set; }
        /// <summary>
        /// Policy Path referencing the Primary site's enforcement point where the info is fetched.
        /// This is applicable only on a GlobalManager.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
