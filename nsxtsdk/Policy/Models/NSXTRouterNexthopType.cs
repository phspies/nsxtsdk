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
    /// Next hop configuration for network
    /// </summary>
    [NSXTProperty(Description: @"Next hop configuration for network")]
    public class NSXTRouterNexthopType 
    {
        /// <summary>
        /// Interface path associated with current route.
        /// For example: specify a policy path referencing the IPSec VPN Session.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
        /// <summary>
        /// Next hop gateway IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Cost associated with next hop route
        /// </summary>
        [JsonProperty(PropertyName = "admin_distance")]
        public int? AdminDistance { get; set; }
    }
}
