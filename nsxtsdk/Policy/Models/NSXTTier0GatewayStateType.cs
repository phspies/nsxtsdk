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
    /// Tier0 gateway state
    /// </summary>
    [NSXTProperty(Description: @"Tier0 gateway state")]
    public class NSXTTier0GatewayStateType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier0_state")]
        public NSXTLogicalRouterStateType Tier0State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "auto_rds")]
        public NSXTAutoRdsType AutoRds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier0_status")]
        public NSXTLogicalRouterStatusType Tier0Status { get; set; }
        /// <summary>
        /// String Path of the enforcement point.
        /// When not specified, routes from all enforcement-points are returned.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone")]
        public NSXTPolicyTransportZoneType TransportZone { get; set; }
        /// <summary>
        /// IPv6 DAD status for interfaces configured on Tier0
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_status")]
        public IList<NSXTIPv6StatusType> Ipv6Status { get; set; }
    }
}
