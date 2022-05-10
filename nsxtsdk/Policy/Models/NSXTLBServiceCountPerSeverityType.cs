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
    /// The service count for specific load balancer usage severity.
    /// </summary>
    [NSXTProperty(Description: @"The service count for specific load balancer usage severity.")]
    public class NSXTLBServiceCountPerSeverityType 
    {
        /// <summary>
        /// Service count for specific serverity.
        /// </summary>
        [JsonProperty(PropertyName = "service_count")]
        public long? ServiceCount { get; set; }
        /// <summary>
        /// The severity calculation is based on current usage percentage
        /// for one load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceCountPerSeveritySeverityEnumType? Severity { get; set; }
    }
}
