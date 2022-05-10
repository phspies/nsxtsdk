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
    /// Advanced load balancer PortRange object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PortRange object")]
    public class NSXTALBPortRangeType 
    {
        /// <summary>
        /// TCP/UDP port range start (inclusive).
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public long Start { get; set; }
        /// <summary>
        /// TCP/UDP port range end (inclusive).
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public long End { get; set; }
    }
}
