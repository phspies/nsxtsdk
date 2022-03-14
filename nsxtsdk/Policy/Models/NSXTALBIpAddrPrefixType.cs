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
    /// Advanced load balancer IpAddrPrefix object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddrPrefix object")]
    public class NSXTALBIpAddrPrefixType 
    {
        /// <summary>
        /// Number of mask.
        /// </summary>
        [JsonProperty(PropertyName = "mask", Required = Required.AllowNull)]
        public long Mask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr", Required = Required.AllowNull)]
        public NSXTALBIpAddrType IpAddr { get; set; }
    }
}
