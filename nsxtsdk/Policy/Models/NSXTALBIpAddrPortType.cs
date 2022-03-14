// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Hostname of server.
        /// One of IP address or hostname should be set.
        /// </summary>
        public string? Hostname { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Port number of server.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
    }
}
