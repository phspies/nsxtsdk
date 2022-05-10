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
    /// Multicast route details.
    /// </summary>
    [NSXTProperty(Description: @"Multicast route details.")]
    public class NSXTMulticastRouteType 
    {
        /// <summary>
        /// Time for which multicast route entry is active.
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        public string? Uptime { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string? Group { get; set; }
        /// <summary>
        /// Time-to-live value for multicast packets.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
        /// <summary>
        /// Ingress interface on which multicast traffic is learned.
        /// </summary>
        [JsonProperty(PropertyName = "input_interface")]
        public string? InputInterface { get; set; }
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Egress interface on which multicast traffic is forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "output_interface")]
        public string? OutputInterface { get; set; }
    }
}
