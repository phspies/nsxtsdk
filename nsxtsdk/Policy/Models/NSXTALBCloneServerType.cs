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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer CloneServer object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CloneServer object")]
    public class NSXTALBCloneServerType 
    {
        /// <summary>
        /// Network to clone the traffic to.
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_path")]
        [NSXTProperty(IsRequired: false, Description: @"Network to clone the traffic to.It is a reference to an object of type Network.")]
        public string? NetworkPath { get; set; }
        /// <summary>
        /// Subnet of the network to clone the traffic to.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        [NSXTProperty(IsRequired: false, Description: @"Subnet of the network to clone the traffic to.")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// MAC Address of the Clone Server.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        [NSXTProperty(IsRequired: false, Description: @"MAC Address of the Clone Server.")]
        public string? Mac { get; set; }
        /// <summary>
        /// IP Address of the Clone Server.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"IP Address of the Clone Server.")]
        public NSXTALBIpAddrType IpAddress { get; set; }
    }
}
