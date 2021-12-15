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
    public class NSXTMulticastForwardingCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Transport node uuid or policy path.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node uuid or policy path.")]
        public string? TransportNode { get; set; }
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast source address.")]
        public string? Source { get; set; }
        /// <summary>
        /// Array of egress interfaces on whic multicast traffic is forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "outgoing_interfaces")]
        [NSXTProperty(IsRequired: false, Description: @"Array of egress interfaces on whic multicast traffic is forwarded.")]
        public string? OutgoingInterfaces { get; set; }
        /// <summary>
        /// Ingress interface on whic multicast traffic is learned.
        /// </summary>
        [JsonProperty(PropertyName = "incoming_interface")]
        [NSXTProperty(IsRequired: false, Description: @"Ingress interface on whic multicast traffic is learned.")]
        public string? IncomingInterface { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "multicast_group")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast group address.")]
        public string? MulticastGroup { get; set; }
    }
}