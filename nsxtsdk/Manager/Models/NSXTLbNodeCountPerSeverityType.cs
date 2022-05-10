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
    /// The node count for specific load balancer usage severity.
    /// </summary>
    [NSXTProperty(Description: @"The node count for specific load balancer usage severity.")]
    public class NSXTLbNodeCountPerSeverityType 
    {
        /// <summary>
        /// Node count for specific serverity.
        /// </summary>
        [JsonProperty(PropertyName = "node_count")]
        public long? NodeCount { get; set; }
        /// <summary>
        /// The severity calculation is based on credit usage percentage of
        /// load balancer for one node.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbNodeCountPerSeveritySeverityEnumType? Severity { get; set; }
    }
}
