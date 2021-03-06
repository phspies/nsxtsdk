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
    /// IP Tunnel port configuration.
    /// </summary>
    [NSXTProperty(Description: @"IP Tunnel port configuration.")]
    public class NSXTTunnelPortConfigType 
    {
        /// <summary>
        /// IP Tunnel port  (commonly referred as VTI) subnet.
        /// </summary>
        [JsonProperty(PropertyName = "ip_subnets", Required = Required.AllowNull)]
        public IList<NSXTIPSubnetType> IpSubnets { get; set; }
        /// <summary>
        /// Logical route port identifier.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_port_id")]
        public string? TunnelPortId { get; set; }
    }
}
