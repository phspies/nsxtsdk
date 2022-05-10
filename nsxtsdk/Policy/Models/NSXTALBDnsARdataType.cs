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
    /// Advanced load balancer DnsARdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsARdata object")]
    public class NSXTALBDnsARdataType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public NSXTALBIpAddrType IpAddress { get; set; }
    }
}
