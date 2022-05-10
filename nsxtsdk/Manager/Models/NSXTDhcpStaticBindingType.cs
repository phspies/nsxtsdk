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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpStaticBindingType : NSXTIpAllocationBaseType
    {
        /// <summary>
        /// The ip address to be assigned to the host.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// The host name to be assigned to the host.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// The MAC address of the host.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
    }
}
