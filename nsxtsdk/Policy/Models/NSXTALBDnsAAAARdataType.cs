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
    /// Advanced load balancer DnsAAAARdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsAAAARdata object")]
    public class NSXTALBDnsAAAARdataType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address", Required = Required.AllowNull)]
        public NSXTALBIpAddrType Ip6Address { get; set; }
    }
}
