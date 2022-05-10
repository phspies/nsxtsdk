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
    /// Advanced load balancer DiscoveredNetwork object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DiscoveredNetwork object")]
    public class NSXTALBDiscoveredNetworkType 
    {
        /// <summary>
        /// Discovered subnet for this IP.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public IList<NSXTALBIpAddrPrefixType> Subnet { get; set; }
        /// <summary>
        /// Discovered IPv6 subnet for this IP.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public IList<NSXTALBIpAddrPrefixType> Subnet6 { get; set; }
        /// <summary>
        /// Discovered network for this IP.
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_name", Required = Required.AllowNull)]
        public string NetworkName { get; set; }
    }
}
