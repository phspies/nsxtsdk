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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMulticastForwardingCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Transport node uuid or policy path.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        public string? TransportNode { get; set; }
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string? Source { get; set; }
        /// <summary>
        /// Array of egress interfaces on whic multicast traffic is forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "outgoing_interfaces")]
        public string? OutgoingInterfaces { get; set; }
        /// <summary>
        /// Ingress interface on whic multicast traffic is learned.
        /// </summary>
        [JsonProperty(PropertyName = "incoming_interface")]
        public string? IncomingInterface { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "multicast_group")]
        public string? MulticastGroup { get; set; }
    }
}
