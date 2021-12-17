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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpStaticBindingType : NSXTIpAllocationBaseType
    {
        public NSXTDhcpStaticBindingType()
        {
        }
        /// <summary>
        /// The ip address to be assigned to the host.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The ip address to be assigned to the host.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpAddress { get; set; }
        /// <summary>
        /// The host name to be assigned to the host.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        [NSXTProperty(IsRequired: false, Description: @"The host name to be assigned to the host.")]
        public string? HostName { get; set; }
        /// <summary>
        /// The MAC address of the host.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The MAC address of the host.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddress { get; set; }
    }
}
