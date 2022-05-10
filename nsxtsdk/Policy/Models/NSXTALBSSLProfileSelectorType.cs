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
    /// Advanced load balancer SSLProfileSelector object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLProfileSelector object")]
    public class NSXTALBSSLProfileSelectorType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_list", Required = Required.AllowNull)]
        public NSXTALBIpAddrMatchType ClientIpList { get; set; }
        /// <summary>
        /// SSL profile for the client IP addresses listed.
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path", Required = Required.AllowNull)]
        public string SslProfilePath { get; set; }
    }
}
