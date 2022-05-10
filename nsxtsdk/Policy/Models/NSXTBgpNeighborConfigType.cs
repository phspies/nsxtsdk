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
    public class NSXTBgpNeighborConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specify path of prefix-list or route map to filter routes for OUT direction.
        /// When not specified, a built-in prefix-list named 'prefixlist-out-default'
        /// is automatically applied.
        /// This property is deprecated, use route_filtering instead. Specifying different
        /// values for both properties will result in error.
        /// </summary>
        [JsonProperty(PropertyName = "out_route_filters")]
        public IList<string> OutRouteFilters { get; set; }
        /// <summary>
        /// If mode is DISABLE, then graceful restart and helper modes are disabled.
        /// If mode is GR_AND_HELPER, then both graceful restart and helper modes are enabled.
        /// If mode is HELPER_ONLY, then helper mode is enabled.
        /// HELPER_ONLY mode is the ability for a BGP speaker to indicate its ability
        /// to preserve forwarding state during BGP restart.
        /// GRACEFUL_RESTART mode is the ability of a BGP speaker to advertise its restart
        /// to its peers.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborConfigGracefulRestartModeEnumType? GracefulRestartMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd")]
        public NSXTBgpBfdConfigType Bfd { get; set; }
        /// <summary>
        /// Interval (in seconds) between keep alive messages sent to peer.
        /// </summary>
        [JsonProperty(PropertyName = "keep_alive_time")]
        public int? KeepAliveTime { get; set; }
        /// <summary>
        /// Maximum number of hops allowed to reach BGP neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_hop_limit")]
        public int? MaximumHopLimit { get; set; }
        /// <summary>
        /// Wait time in seconds before declaring peer dead.
        /// </summary>
        [JsonProperty(PropertyName = "hold_down_time")]
        public int? HoldDownTime { get; set; }
        /// <summary>
        /// Specify path of prefix-list or route map to filter routes for IN direction.
        /// This property is deprecated, use route_filtering instead. Specifying different
        /// values for both properties will result in error.
        /// </summary>
        [JsonProperty(PropertyName = "in_route_filters")]
        public IList<string> InRouteFilters { get; set; }
        /// <summary>
        /// 4 Byte ASN of the neighbor in ASPLAIN Format
        /// </summary>
        [JsonProperty(PropertyName = "remote_as_num", Required = Required.AllowNull)]
        public string RemoteAsNum { get; set; }
        /// <summary>
        /// Enable address families and route filtering in each direction.
        /// </summary>
        [JsonProperty(PropertyName = "route_filtering")]
        public IList<NSXTBgpRouteFilteringType> RouteFiltering { get; set; }
        /// <summary>
        /// Source addresses should belong to Tier0 external or loopback interface
        /// IP Addresses . BGP peering is formed from all these addresses.
        /// This property is mandatory when maximum_hop_limit is greater than 1.
        /// </summary>
        [JsonProperty(PropertyName = "source_addresses")]
        public IList<string> SourceAddresses { get; set; }
        /// <summary>
        /// Specify password for BGP neighbor authentication.
        /// Empty string ("") clears existing password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Flag to enable allowas_in option for BGP neighbor
        /// </summary>
        [JsonProperty(PropertyName = "allow_as_in")]
        public bool? AllowAsIn { get; set; }
        /// <summary>
        /// Neighbor IP Address
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address", Required = Required.AllowNull)]
        public string NeighborAddress { get; set; }
    }
}
