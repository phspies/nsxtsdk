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
    /// An Endpoint object is part of HostSwitch configuration in TransportNode
    /// </summary>
    [NSXTProperty(Description: @"An Endpoint object is part of HostSwitch configuration in TransportNode")]
    public class NSXTEndpointType 
    {
        /// <summary>
        /// Subnet mask
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask")]
        [NSXTProperty(IsRequired: false, Description: @"Subnet mask")]
        public string? SubnetMask { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        [NSXTProperty(IsRequired: false, Description: @"MAC address")]
        public string? Mac { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway IP")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// Depending upon the EndpointIpConfig used in HostSwitch, IP could be allocated either from DHCP (default) or from Static
        /// IP Pool.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [NSXTProperty(IsRequired: false, Description: @"Depending upon the EndpointIpConfig used in HostSwitch, IP could be allocated either from DHCP (default) or from Static IP Pool.")]
        public string? Ip { get; set; }
        /// <summary>
        /// Name of the virtual tunnel endpoint
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the virtual tunnel endpoint")]
        public string? DeviceName { get; set; }
        /// <summary>
        /// Unique label for this Endpoint
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        [NSXTProperty(IsRequired: false, Description: @"Unique label for this Endpoint")]
        public int? Label { get; set; }
    }
}
