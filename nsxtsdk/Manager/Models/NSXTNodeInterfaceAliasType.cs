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
    /// Node network interface alias
    /// </summary>
    [NSXTProperty(Description: @"Node network interface alias")]
    public class NSXTNodeInterfaceAliasType 
    {
        /// <summary>
        /// Interface configuration
        /// </summary>
        [JsonProperty(PropertyName = "ip_configuration")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfaceAliasIpConfigurationEnumType? IpConfiguration { get; set; }
        /// <summary>
        /// Interface netmask
        /// </summary>
        [JsonProperty(PropertyName = "netmask")]
        public string? Netmask { get; set; }
        /// <summary>
        /// Interface IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Interface MAC address
        /// </summary>
        [JsonProperty(PropertyName = "physical_address")]
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Interface broadcast address
        /// </summary>
        [JsonProperty(PropertyName = "broadcast_address")]
        public string? BroadcastAddress { get; set; }
    }
}
