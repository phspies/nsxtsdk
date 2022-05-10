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
    public class NSXTStaticRouteNextHopType 
    {
        /// <summary>
        /// Action to be taken on matching packets for NULL routes.
        /// </summary>
        [JsonProperty(PropertyName = "blackhole_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTStaticRouteNextHopBlackholeActionEnumType? BlackholeAction { get; set; }
        /// <summary>
        /// Administrative Distance for the next hop IP
        /// </summary>
        [JsonProperty(PropertyName = "administrative_distance")]
        public long? AdministrativeDistance { get; set; }
        /// <summary>
        /// Next Hop IP
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Status of bfd for this next hop where bfd_enabled = true indicate bfd is enabled for this next hop and bfd_enabled =
        /// false indicate bfd peer is disabled or not configured for this next hop.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_enabled")]
        public bool? BfdEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_port_id")]
        public NSXTResourceReferenceType LogicalRouterPortId { get; set; }
    }
}
