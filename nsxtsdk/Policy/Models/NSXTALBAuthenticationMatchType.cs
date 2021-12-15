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
    /// Advanced load balancer AuthenticationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthenticationMatch object")]
    public class NSXTALBAuthenticationMatchType 
    {
        /// <summary>
        /// Configure the host header.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        [NSXTProperty(IsRequired: false, Description: @"Configure the host header.")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// Configure client ip addresses.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Configure client ip addresses.")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Configure request paths.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [NSXTProperty(IsRequired: false, Description: @"Configure request paths.")]
        public NSXTALBPathMatchType Path { get; set; }
    }
}
