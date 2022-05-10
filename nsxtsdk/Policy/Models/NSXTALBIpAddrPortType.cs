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
    /// Advanced load balancer IpAddrPort object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddrPort object")]
    public class NSXTALBIpAddrPortType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Hostname of server.
        /// One of IP address or hostname should be set.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Port number of server.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
    }
}
