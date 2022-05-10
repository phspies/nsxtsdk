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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVPNIKEServiceSummaryType : NSXTIPSecVPNSessionSummaryType
    {
        /// <summary>
        /// UUID for a vpn service.
        /// </summary>
        [JsonProperty(PropertyName = "ipsec_vpn_service_id")]
        public string? IpsecVpnServiceId { get; set; }
        /// <summary>
        /// VPN service display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Logical router identifier associated with vpn service.
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
    }
}
