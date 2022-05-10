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
    /// Multicast forwarding entry.
    /// </summary>
    [NSXTProperty(Description: @"Multicast forwarding entry.")]
    public class NSXTMulticastForwardingType 
    {
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string? Source { get; set; }
        /// <summary>
        /// Array of egress interfaces on whic multicast traffic is forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "outgoing_interfaces")]
        public IList<NSXTMulticastForwardingInterfaceType> OutgoingInterfaces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "incoming_interface")]
        public NSXTMulticastForwardingInterfaceType IncomingInterface { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "multicast_group")]
        public string? MulticastGroup { get; set; }
    }
}
