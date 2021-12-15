// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMulticastRouteCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Transport node uuid or policy path.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node uuid or policy path.")]
        public string? TransportNode { get; set; }
        /// <summary>
        /// Time for which multicast route entry is active.
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        [NSXTProperty(IsRequired: false, Description: @"Time for which multicast route entry is active.")]
        public string? Uptime { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast group address.")]
        public string? Group { get; set; }
        /// <summary>
        /// Time-to-live value for multicast packets.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        [NSXTProperty(IsRequired: false, Description: @"Time-to-live value for multicast packets.")]
        public long? Ttl { get; set; }
        /// <summary>
        /// Ingress interface on which multicast traffic is learned.
        /// </summary>
        [JsonProperty(PropertyName = "input_interface")]
        [NSXTProperty(IsRequired: false, Description: @"Ingress interface on which multicast traffic is learned.")]
        public string? InputInterface { get; set; }
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast source address.")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Egress interface on which multicast traffic is forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "output_interface")]
        [NSXTProperty(IsRequired: false, Description: @"Egress interface on which multicast traffic is forwarded.")]
        public string? OutputInterface { get; set; }
    }
}
