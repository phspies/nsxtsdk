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
        [NSXTProperty(IsRequired: false, Description: @"Interface netmask")]
        public string? Netmask { get; set; }
        /// <summary>
        /// Interface IPv4 address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"Interface IPv4 address")]
        public string? IpAddress { get; set; }
    }
}
