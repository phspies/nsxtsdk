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
    /// A packet is classified to have an address binding, if its address
        /// configuration matches with all user specified properties.
    /// </summary>
    [NSXTProperty(Description: @"A packet is classified to have an address binding, if its addressconfiguration matches with all user specified properties.")]
    public class NSXTPacketAddressClassifierType 
    {
        /// <summary>
        /// Virtual Local Area Network Identifier
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
        /// <summary>
        /// A single IP address or a subnet, e.g. x.x.x.x or x.x.x.x/y
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// A single MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
    }
}
