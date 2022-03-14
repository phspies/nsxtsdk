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
    /// Advanced load balancer DnsClientIpMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsClientIpMatch object")]
    public class NSXTALBDnsClientIpMatchType 
    {
        /// <summary>
        /// Use the IP address from the EDNS client subnet option, if
        /// available, as the source IP address of the client.
        /// It should be noted that the edns subnet IP may not be a /32
        /// IP address.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        public bool? UseEdnsClientSubnetIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip", Required = Required.AllowNull)]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
    }
}
