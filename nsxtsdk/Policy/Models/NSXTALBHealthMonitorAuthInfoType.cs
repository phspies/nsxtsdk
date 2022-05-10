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
    /// Advanced load balancer HealthMonitorAuthInfo object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorAuthInfo object")]
    public class NSXTALBHealthMonitorAuthInfoType 
    {
        /// <summary>
        /// Username for server authentication.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password for server authentication.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
