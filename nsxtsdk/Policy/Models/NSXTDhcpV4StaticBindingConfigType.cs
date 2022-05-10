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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpV4StaticBindingConfigType : NSXTDhcpStaticBindingConfigType
    {
        /// <summary>
        /// When not specified, gateway address is auto-assigned from segment
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_address")]
        public string? GatewayAddress { get; set; }
        /// <summary>
        /// Hostname to assign to the host.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// MAC address of the host.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
        /// <summary>
        /// DHCP lease time in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// IP assigned to host. The IP address must belong to the subnet, if any,
        /// configured on Segment.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public NSXTDhcpV4OptionsType Options { get; set; }
    }
}
