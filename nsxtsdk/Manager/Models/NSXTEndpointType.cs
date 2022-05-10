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
    /// An Endpoint object is part of HostSwitch configuration in TransportNode
    /// </summary>
    [NSXTProperty(Description: @"An Endpoint object is part of HostSwitch configuration in TransportNode")]
    public class NSXTEndpointType 
    {
        /// <summary>
        /// Subnet mask
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask")]
        public string? SubnetMask { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// Depending upon the EndpointIpConfig used in HostSwitch, IP could be allocated either from DHCP (default) or from Static
        /// IP Pool.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Name of the virtual tunnel endpoint
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        public string? DeviceName { get; set; }
        /// <summary>
        /// Unique label for this Endpoint
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public int? Label { get; set; }
    }
}
