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
    /// Advanced load balancer NetworkSecurityMatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkSecurityMatchTarget object")]
    public class NSXTALBNetworkSecurityMatchTargetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "microservice")]
        public NSXTALBMicroServiceMatchType Microservice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vs_port")]
        public NSXTALBPortMatchType VsPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
    }
}
