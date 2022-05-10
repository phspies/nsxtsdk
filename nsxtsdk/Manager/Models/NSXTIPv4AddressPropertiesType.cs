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
    /// IPv4 address properties
    /// </summary>
    [NSXTProperty(Description: @"IPv4 address properties")]
    public class NSXTIPv4AddressPropertiesType 
    {
        /// <summary>
        /// Interface netmask
        /// </summary>
        [JsonProperty(PropertyName = "netmask")]
        public string? Netmask { get; set; }
        /// <summary>
        /// Interface IPv4 address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
