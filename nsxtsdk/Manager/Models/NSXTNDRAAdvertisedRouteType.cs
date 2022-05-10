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
    public class NSXTNDRAAdvertisedRouteType 
    {
        /// <summary>
        /// Advertised route subnet
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        public string Subnet { get; set; }
        /// <summary>
        /// NDRA Route preference. Indicates preference of the router associated
        /// with a prefix over others, when multiple identical prefixes (for
        /// different routers) have been received.
        /// </summary>
        [JsonProperty(PropertyName = "route_preference")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNdraadvertisedRouteRoutePreferenceEnumType? RoutePreference { get; set; }
        /// <summary>
        /// Lifetime of advertised route in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "route_lifetime")]
        public long? RouteLifetime { get; set; }
    }
}
