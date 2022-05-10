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
    /// Advanced load balancer PerformanceLimits object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PerformanceLimits object")]
    public class NSXTALBPerformanceLimitsType 
    {
        /// <summary>
        /// The maximum number of concurrent client conections allowed
        /// to the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections")]
        public long? MaxConcurrentConnections { get; set; }
        /// <summary>
        /// The maximum throughput per second for all clients allowed
        /// through the client side of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "max_throughput")]
        public long? MaxThroughput { get; set; }
    }
}
