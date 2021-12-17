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
    /// Tier0 gateway state
    /// </summary>
    [NSXTProperty(Description: @"Tier0 gateway state")]
    public class NSXTTier0GatewayStateType 
    {
        public NSXTTier0GatewayStateType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier0_state")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLogicalRouterStateType Tier0State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "auto_rds")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTAutoRdsType AutoRds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tier0_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLogicalRouterStatusType Tier0Status { get; set; }
        /// <summary>
        /// String Path of the enforcement point.
        /// When not specified, routes from all enforcement-points are returned.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        [NSXTProperty(IsRequired: false, Description: @"String Path of the enforcement point.When not specified, routes from all enforcement-points are returned.")]
        public string? EnforcementPointPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTPolicyTransportZoneType TransportZone { get; set; }
        /// <summary>
        /// IPv6 DAD status for interfaces configured on Tier0
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_status")]
        [NSXTProperty(IsRequired: false, Description: @"IPv6 DAD status for interfaces configured on Tier0")]
        public IList<NSXTIPv6StatusType> Ipv6Status { get; set; }
    }
}
