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
    /// Duplicate address detection status for IP address on the interface.
    /// </summary>
    [NSXTProperty(Description: @"Duplicate address detection status for IP address on the interface.")]
    public class NSXTInterfaceIPv6DADStatusType 
    {
        /// <summary>
        /// DAD status for IP address on the port.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInterfaceIpv6DadstatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Array of edge nodes on which DAD status is reported for
        /// given IP address.
        /// </summary>
        [JsonProperty(PropertyName = "edge_paths")]
        public IList<string> EdgePaths { get; set; }
        /// <summary>
        /// IP address on the port for which DAD status is reported.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
