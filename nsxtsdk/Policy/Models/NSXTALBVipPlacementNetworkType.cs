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
    /// Advanced load balancer VipPlacementNetwork object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer VipPlacementNetwork object")]
    public class NSXTALBVipPlacementNetworkType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
        /// <summary>
        /// Network to use for vip placement.
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
    }
}
