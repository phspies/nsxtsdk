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
    /// DHCP option 121 to define classless static route.
    /// </summary>
    [NSXTProperty(Description: @"DHCP option 121 to define classless static route.")]
    public class NSXTDhcpOption121Type 
    {
        /// <summary>
        /// Classless static route of DHCP option 121.
        /// </summary>
        [JsonProperty(PropertyName = "static_routes", Required = Required.AllowNull)]
        public IList<NSXTClasslessStaticRouteType> StaticRoutes { get; set; }
    }
}
