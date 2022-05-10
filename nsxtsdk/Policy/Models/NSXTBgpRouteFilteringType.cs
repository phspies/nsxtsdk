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
    /// Enable address_families and route filtering in each direction
    /// </summary>
    [NSXTProperty(Description: @"Enable address_families and route filtering in each direction")]
    public class NSXTBgpRouteFilteringType 
    {
        /// <summary>
        /// Specify path of prefix-list or route map to filter routes for OUT direction.
        /// When not specified, a built-in prefix-list named 'prefixlist-out-default'
        /// is automatically applied.
        /// </summary>
        [JsonProperty(PropertyName = "out_route_filters")]
        public IList<string> OutRouteFilters { get; set; }
        /// <summary>
        /// Specify path of prefix-list or route map to filter routes for IN direction.
        /// </summary>
        [JsonProperty(PropertyName = "in_route_filters")]
        public IList<string> InRouteFilters { get; set; }
        /// <summary>
        /// Flag to enable address family.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Address family type.
        /// If not configured, this property automatically derived for IPv4 & IPv6
        /// peer configuration.
        /// </summary>
        [JsonProperty(PropertyName = "address_family")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpRouteFilteringAddressFamilyEnumType? AddressFamily { get; set; }
        /// <summary>
        /// Maximum number of routes for the address family.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_routes")]
        public int? MaximumRoutes { get; set; }
    }
}
