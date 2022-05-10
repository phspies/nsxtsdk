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
    /// Advanced load balancer AuthenticationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthenticationMatch object")]
    public class NSXTALBAuthenticationMatchType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
    }
}
