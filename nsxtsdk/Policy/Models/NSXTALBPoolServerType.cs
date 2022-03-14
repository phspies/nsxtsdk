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
    /// Advanced load balancer PoolServer object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PoolServer object")]
    public class NSXTALBPoolServerType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// DNS resolvable name of the server.
        /// May be used in place of the IP address.
        /// </summary>
        public string? Hostname { get; set; }
        /// <summary>
        /// Port of the pool server listening for HTTP/HTTPS.
        /// Default value is the default port in the pool.
        /// Allowed values are 1-65535.
        /// </summary>
        public long? Port { get; set; }
    }
}
