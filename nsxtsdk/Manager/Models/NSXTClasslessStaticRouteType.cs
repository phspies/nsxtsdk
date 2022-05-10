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
    /// DHCP classless static route option.
    /// </summary>
    [NSXTProperty(Description: @"DHCP classless static route option.")]
    public class NSXTClasslessStaticRouteType 
    {
        /// <summary>
        /// IP address of next hop of the route.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop", Required = Required.AllowNull)]
        public string NextHop { get; set; }
        /// <summary>
        /// Destination network in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
    }
}
