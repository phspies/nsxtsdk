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
    /// Advanced load balancer CloneServer object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer CloneServer object")]
    public class NSXTALBCloneServerType 
    {
        /// <summary>
        /// Network to clone the traffic to.
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// MAC Address of the Clone Server.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
