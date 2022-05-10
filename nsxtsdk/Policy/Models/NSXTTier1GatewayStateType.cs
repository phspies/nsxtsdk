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
    /// Tier1 gateway state
    /// </summary>
    [NSXTProperty(Description: @"Tier1 gateway state")]
    public class NSXTTier1GatewayStateType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier1_status")]
        public NSXTLogicalRouterStatusType Tier1Status { get; set; }
        /// <summary>
        /// IPv6 DAD status for interfaces configured on Tier1
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_status")]
        public IList<NSXTIPv6StatusType> Ipv6Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier1_state")]
        public NSXTLogicalRouterStateType Tier1State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone")]
        public NSXTPolicyTransportZoneType TransportZone { get; set; }
        /// <summary>
        /// String Path of the enforcement point.
        /// When not specified, routes from all enforcement-points are returned.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
