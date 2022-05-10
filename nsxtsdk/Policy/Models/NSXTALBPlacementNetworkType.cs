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
    /// Advanced load balancer PlacementNetwork object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PlacementNetwork object")]
    public class NSXTALBPlacementNetworkType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_name", Required = Required.AllowNull)]
        public string NetworkName { get; set; }
    }
}
