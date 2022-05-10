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
    /// Advanced load balancer DnsNsRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsNsRdata object")]
    public class NSXTALBDnsNsRdataType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public NSXTALBIpAddrType Ip6Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// Name Server name.
        /// </summary>
        [JsonProperty(PropertyName = "nsname", Required = Required.AllowNull)]
        public string Nsname { get; set; }
    }
}
