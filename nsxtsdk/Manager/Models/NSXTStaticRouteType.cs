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
    public class NSXTStaticRouteType : NSXTManagedResourceType
    {
        /// <summary>
        /// Next Hops
        /// </summary>
        [JsonProperty(PropertyName = "next_hops", Required = Required.AllowNull)]
        public IList<NSXTStaticRouteNextHopType> NextHops { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// CIDR
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
    }
}
